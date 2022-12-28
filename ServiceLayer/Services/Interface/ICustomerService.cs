using DomainLayer.Moldels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interface
{
    public interface ICustomerService
    {
        int GetCustomerCountByFiltered();
        //string GetCustomersByFiltered(int startAge, int endAge);
        Customer[] GetCustomersByFiltered(int startAge, int endAge);
        double GetCustomersAverageByAges();
         


    }
}
