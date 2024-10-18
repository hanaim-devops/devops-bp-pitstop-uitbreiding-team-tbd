namespace Pitstop.WebApp.Commands;

public class RegisterRental : Command
{
    public readonly string LicenseNumber;
    public readonly DateTime StartDate;
    public readonly DateTime EndDate;
    public readonly string OwnerId;

    public RegisterRental(Guid messageId, string licenseNumber, DateTime startDate, DateTime endDate, string ownerId) :
        base(messageId)
    {
        LicenseNumber = licenseNumber;
        StartDate = startDate;
        EndDate = endDate;
        OwnerId = ownerId;
    }
}