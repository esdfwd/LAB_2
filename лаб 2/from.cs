namespace лаб_2
{
    internal class from
    {
    }
}
using System;

public class Address
{
    public string Index { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string House { get; set; }
    public string Apartment { get; set; }

    public Address(string index, string country, string city, string street, string house, string apartment)
    {
        Index = index;
        Country = country;
        City = city;
        Street = street;
        House = house;
        Apartment = apartment;
    }
}

public class Converter
{
    private double usd;
    private double eur;
    private double pln;

    public Converter(double usd, double eur, double pln)
    {
        this.usd = usd;
        this.eur = eur;
        this.pln = pln;
    }

    public double ConvertToUah(double amount, string currency)
    {
        if (currency == "USD")
        {
            return amount * usd;
        }
        else if (currency == "EUR")
        {
            return amount * eur;
        }
        else if (currency == "PLN")
        {
            return amount * pln;
        }
        else
        {
            return 0.0; // Невідома валюта
        }
    }

    public double ConvertFromUah(double amount, string currency)
    {
        if (currency == "USD")
        {
            return amount / usd;
        }
        else if (currency == "EUR")
        {
            return amount / eur;
        }
        else if (currency == "PLN")
        {
            return amount / pln;
        }
        else
        {
            return 0.0; // Невідома валюта
        }
    }
}

class Program 
{
    static void Main(string[] args)
    {
        // Приклад використання класу Address
        Address address = new Address("12345", "Україна", "Київ", "Вулиця Хрещатик", "1", "5");

        Console.WriteLine("Індекс: " + address.Index);
        Console.WriteLine("Країна: " + address.Country);
        Console.WriteLine("Місто: " + address.City);
        Console.WriteLine("Вулиця: " + address.Street);
        Console.WriteLine("Будинок: " + address.House);
        Console.WriteLine("Квартира: " + address.Apartment);

        // Приклад використання класу Converter
        double usdRate = 26.5;
        double eurRate = 31.2;
        double plnRate = 6.0;

        Converter converter = new Converter(usdRate, eurRate, plnRate);

        Console.Write("Введіть суму в гривнях: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть валюту для конвертації (USD, EUR, PLN): ");
        string currency = Console.ReadLine();

        if (currency == "USD" || currency == "EUR" || currency == "PLN")
        {
            double convertedAmount = converter.ConvertToUah(amount, currency);
            Console.WriteLine($"{amount} UAH = {convertedAmount} {currency}");
        }
        else
        {
            Console.WriteLine("Невідома валюта");
        }
    }
}
