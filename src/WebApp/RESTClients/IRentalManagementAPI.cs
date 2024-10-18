namespace WebApp.RESTClients;

public interface IRentalManagementAPI
{
    [Get("/rentals")]
    Task<List<Rental>> GetRentals();
    
    [Post("/rentals")]
    Task RegisterRental(RegisterRental command);
}