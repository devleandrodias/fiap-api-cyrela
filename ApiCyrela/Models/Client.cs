using System;
namespace ApiCyrela.Models
{
    public class Client
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Job { get; set; }

        public double Salary { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
