﻿namespace Pitstop.WebApp.Models;

public class Model
{
    public string Id { get; set; }
    public Brand Brand { get; set; }
    [Display(Name = "Type")]
    public string Name { get; set; }
}