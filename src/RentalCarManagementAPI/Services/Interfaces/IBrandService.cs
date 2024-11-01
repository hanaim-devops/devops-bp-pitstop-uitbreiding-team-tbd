using System.Threading.Tasks;
using RentalCarManagementAPI.Models;

namespace Pitstop.RentalCarManagementAPI.Services.Interfaces;

public interface IBrandService
{
    public Task<Brand> GetByName(string name);
}