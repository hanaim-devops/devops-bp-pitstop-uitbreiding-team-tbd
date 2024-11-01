using System.Threading.Tasks;
using RentalCarManagementAPI.Models;

namespace Pitstop.RentalCarManagementAPI.Services.Interfaces;

public interface IModelService
{
    public Task<Model> GetByName(string brand, string name);
}