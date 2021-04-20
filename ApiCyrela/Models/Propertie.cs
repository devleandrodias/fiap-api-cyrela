using System;

namespace ApiCyrela.Models
{
    public class Propertie
    {
        public Guid Id { get; set; }

        public ETypePropertie TypePropertie { get; set; }

        public double Amount { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Street { get; set; }

        public string ZipCode { get; set; }

        public string Neighborhood { get; set; }
    }

    public enum ETypePropertie
    {
        HOUSE,
        APARTAMENT,
        KITNET,
    }
}
