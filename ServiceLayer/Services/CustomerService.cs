using DomainLayer.Moldels;
using ServiceLayer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class CustomerService : ICustomerService
    {
        public int GetCustomerCountByFiltered()
        {

            var customers = GetAll();

            int count = 0;

            foreach (var item in customers)
            {
                if (item.Age > 25 && item.Age < 30)
                {
                    count++;    
                }
            }

            return count;
        }

        public double GetCustomersAverageByAges()
        {
            var customers = GetAll();
            double sumAge = 0;

            foreach (var item in customers)
            {
                sumAge += item.Age;
            }
            

            //return sumAge / customers.Length;

            return Math.Ceiling(sumAge / customers.Length);

        }

        //public string GetCustomersByFiltered(int startAge, int endAge)
        public Customer[] GetCustomersByFiltered(int startAge, int endAge)
        {

            var customers = GetAll();

            //string datas = string.Empty;

            Customer[] result = new Customer[customers.Length];

            int count = 0;

            foreach (var item in customers)
            {
                if (item.Age > startAge && item.Age < endAge)
                {

                    result[count] = item;
                    count++;

                    //datas += ($"{item.Id} {item.Name} {item.Surname} {item.Age} {item.Position}------");
                }
            }

            return result;
            //return datas;
        }

        private Customer[] GetAll()
        {
            Customer c1 = new Customer
            {
                    Id = 1,
                    Name = "Shaiq",
                    Surname = "Kazimov",
                    Age = 25,
                    Position = "Backed developer"

            };


            Customer c2 = new Customer
            {
                Id = 2,
                Name = "Pervin",
                Surname = "Rehimli",
                Age = 25,
                Position = "Frontend developer"

            };


            Customer c3 = new Customer
            {
                Id = 3,
                Name = "Aqshin",
                Surname = "Hummetov",
                Age = 27,
                Position = "Fullstack developer"

            };


            Customer c4 = new Customer
            {
                Id = 4,
                Name = "Jale",
                Surname = "Abdullayeva",
                Age = 18,
                Position = "Software instuctor"

            };

            Customer[] customers= new Customer[] { c1, c2, c3, c4 };    
            return customers;


        }




    }
}
