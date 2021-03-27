using System;

namespace ImplicitOperator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Celalettin",
                MiddleName = "Timoqi",
                LastName = "Altintas"
            };

            CustomerDto customerDto = customer;

            Console.WriteLine(customerDto.ToString());
            Console.ReadKey();
        }
    }


    internal class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }

    internal class CustomerDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }


        public static implicit operator CustomerDto(Customer customer)
        {
            return new CustomerDto
            {
                Id = customer.Id,
                FullName = $"{customer.FirstName} {customer.MiddleName} {customer.LastName}"
            };
        }

        public override string ToString()
        {
            return $"{Id} : {FullName}";
        }
    }
}