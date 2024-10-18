namespace PitStop.WebApp.Controllers;

public class RentalManagementController : Controller
{
    private IRentalManagementAPI _rentalManagementAPI;
    private IRentalCarManagementAPI _rentalCarManagementAPI;
    private ICustomerManagementAPI _customerManagementAPI;
    private readonly Microsoft.Extensions.Logging.ILogger _logger;
    private ResiliencyHelper _resiliencyHelper;

    public RentalManagementController(IRentalManagementAPI rentalManagementAPI, IRentalCarManagementAPI rentalCarManagementAPI, ICustomerManagementAPI customerManagementAPI, ILogger<RentalManagementController> logger)
    {
        _rentalManagementAPI = rentalManagementAPI;
        _rentalCarManagementAPI = rentalCarManagementAPI;
        _customerManagementAPI = customerManagementAPI;
        _logger = logger;
        _resiliencyHelper = new ResiliencyHelper(_logger);
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return await _resiliencyHelper.ExecuteResilient(async () =>
        {
            List<Rental> rentals = await _rentalManagementAPI.GetRentals();

            var model = new RentalManagementViewModel
            {
                Rentals = rentals
            };

            model.Rentals.OrderBy(r => r.StartDate);

            return View(model);
        }, View("Offline", new RentalManagementOfflineViewModel()));
    }
    
    
    [HttpGet]
    public async Task<IActionResult> New()
    {
        return await _resiliencyHelper.ExecuteResilient(async () =>
        {
            DateTime currentDate = DateTime.Today;
            var customers = await _customerManagementAPI.GetCustomers();

            var model = new RentalManagementNewViewModel
            {
                Id = Guid.NewGuid(),
                StartDate = currentDate,
                EndDate = currentDate.AddDays(1),
                RentalCars = await GetAvailableRentalCarsList(),
                Customers = customers.Select(c => new SelectListItem { Value = c.CustomerId, Text = c.Name })
            };
            return View(model);
        }, View("Offline", new RentalManagementOfflineViewModel()));
    }

    [HttpPost]
    public async Task<IActionResult> RegisterCarRental([FromForm] RentalManagementNewViewModel inputModel)
    {
        if (ModelState.IsValid)
        {
            return await _resiliencyHelper.ExecuteResilient(async () =>
            {
                try
                {
                    //     // register maintenance job
                    //     DateTime startTime = inputModel.Date.Add(inputModel.StartTime.TimeOfDay);
                    // DateTime endTime = inputModel.Date.Add(inputModel.EndTime.TimeOfDay);
                    // Vehicle vehicle = await _workshopManagementAPI.GetVehicleByLicenseNumber(inputModel.SelectedVehicleLicenseNumber);
                    // Customer customer = await _workshopManagementAPI.GetCustomerById(vehicle.OwnerId);
                    //
                    // PlanMaintenanceJob planMaintenanceJobCommand = new PlanMaintenanceJob(Guid.NewGuid(), Guid.NewGuid(), startTime, endTime,
                    //     (customer.CustomerId, customer.Name, customer.TelephoneNumber),
                    //     (vehicle.LicenseNumber, vehicle.Brand, vehicle.Type), inputModel.Description);
                    // await _workshopManagementAPI.PlanMaintenanceJob(dateStr, planMaintenanceJobCommand);
                }
                catch (ApiException ex)
                {
                    if (ex.StatusCode == HttpStatusCode.Conflict)
                    {
                            // add errormessage from API exception to model
                            var content = await ex.GetContentAsAsync<BusinessRuleViolation>();
                        inputModel.Error = content.ErrorMessage;

                            // repopulate list of available vehicles in the model
                            inputModel.RentalCars = await GetAvailableRentalCarsList();

                            // back to New view
                            return View("New", inputModel);
                    }
                }

                return RedirectToAction("Index");
            }, View("Offline", new RentalManagementOfflineViewModel()));
        }
        else
        {
            // inputModel.Vehicles = await GetAvailableVehiclesList();
            return View("New", inputModel);
        }
    }
    
    private async Task<IEnumerable<SelectListItem>> GetAvailableRentalCarsList()
    {
        var rentalCars = await _rentalCarManagementAPI.GetRentalCars();
        return rentalCars.Select(rentalCar =>
            new SelectListItem
            {
                Value = rentalCar.LicenseNumber,
                Text = $"{rentalCar.Model.Brand.Name} {rentalCar.Model.Name} [{rentalCar.LicenseNumber}]"
            });
    }
}