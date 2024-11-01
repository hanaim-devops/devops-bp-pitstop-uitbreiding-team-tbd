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

public class BrandService(RentalCarManagementDBContext dbContext, IMessagePublisher publisher, IMapper mapper) : IBrandService
{
    private RentalCarManagementDBContext _dbContext = dbContext;
    private IMessagePublisher _publisher = publisher;
    private IMapper _mapper = mapper;
    
    public async Task<Brand> GetByName(string name)
    {
        var brand = _dbContext.Brands.FirstOrDefault(b => b.Name == name);
        return brand ?? await Add(name);
    }
    
    private async Task<Brand> Add(string name)
    {
        var brand = new Brand()
        {
            Id = Guid.NewGuid().ToString(),
            Name = name
        };
        
        _dbContext.Brands.Add(brand);
        await _dbContext.SaveChangesAsync();
        
        var @event = _mapper.Map<BrandRegistered>(brand);
        await _publisher.PublishMessageAsync(@event.MessageType, @event, "");
        
        return brand;
    }
}