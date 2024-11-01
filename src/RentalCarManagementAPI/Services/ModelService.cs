using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Pitstop.Infrastructure.Messaging;
using Pitstop.RentalCarManagementAPI.Events;
using Pitstop.RentalCarManagementAPI.Services.Interfaces;
using RentalCarManagementAPI;
using RentalCarManagementAPI.Models;

namespace Pitstop.RentalCarManagementAPI.Services;

public class ModelService(RentalCarManagementDBContext dbContext, IBrandService brandService, IMessagePublisher publisher, IMapper mapper) : IModelService
{
    private RentalCarManagementDBContext _dbContext = dbContext;
    private IBrandService _brandService = brandService;
    private IMessagePublisher _publisher = publisher;
    private IMapper _mapper = mapper;
    
    public async Task<Model> GetByName(string brandName, string name)
    {
        var brand = await _brandService.GetByName(brandName);
        var model = _dbContext.Models.FirstOrDefault(m => m.Name == name && m.BrandId == brand.Id);
        return model ?? await AddModel(brand, name);
    }

    private async Task<Model> AddModel(Brand brand, string name)
    {
        var model = new Model()
        {
            Id = Guid.NewGuid().ToString(),
            Brand = brand,
            Name = name
        };
        
        _dbContext.Models.Add(model);
        _dbContext.SaveChanges();
        
        var @event = _mapper.Map<ModelRegistered>(model);
        await _publisher.PublishMessageAsync(@event.MessageType, @event, "");
        
        return model;
    }
}