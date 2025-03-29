using System;
using System.Collections.Generic;

class Car
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public double FuelConsumption { get; set; } 
    public double TotalDistance { get; set; } 

    public double CalculateTotalFuel()
    {
        return (TotalDistance / 100) * FuelConsumption;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Marka: {Marka}, Model: {Model}, 100 km'de Yaktığı Yakıt: {FuelConsumption} litre, Toplam Yakıt Tüketimi: {CalculateTotalFuel():F0} litre");
    }
}