namespace WebApp.RESTClients;

public class RentalManagementAPI : IRentalManagementAPI
{
    private IRentalManagementAPI _restClient;
    
    public RentalManagementAPI(IConfiguration config, HttpClient httpClient)
    {
        string apiHostAndPort = config.GetSection("APIServiceLocations").GetValue<string>("RentalManagementAPI");
        httpClient.BaseAddress = new Uri($"http://{apiHostAndPort}/api");
        _restClient = RestService.For<IRentalManagementAPI>(
            httpClient,
            new RefitSettings
            {
                ContentSerializer = new NewtonsoftJsonContentSerializer()
            });
    }

    public async Task<List<Rental>> GetRentals()
    {
        return await _restClient.GetRentals();
    }
    
    public async Task RegisterRental(RegisterRental command)
    {
        await _restClient.RegisterRental(command);
    }
}