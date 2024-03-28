﻿namespace Exceptions.Models;

public class Product
{
    public int Id { get; set; }
    public string Title { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }

    public Category Category { get; set; }


    public override string ToString()
    {
        return $"Id: {Id}\n Title: {Title}\n Price: {Price}\n Description: {Description}\n Category: {Category}\n";
    }

}
