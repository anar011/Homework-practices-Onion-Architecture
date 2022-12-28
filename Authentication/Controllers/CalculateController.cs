using ServiceLayer.Services;
using ServiceLayer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Controllers
{
    public class CalculateController
    {

        private readonly ICalculateService _services;
        public CalculateController()
        {
            _services= new CalculateService();
        }




        public void MultiplyArrayItems() => Console.WriteLine(_services.MultiplyArrayItems(GetArr()));
        //{

        //    Console.WriteLine(_services.MultiplyArrayItems(GetArr()));

        //    //int[] arr = { 1, 2, 3, 4, 5, 6, 12 };

        //    //var result = GetArr();
        //    //Console.WriteLine(_services.MultiplyArrayItems(result));


        //    //Console.WriteLine( _services.MultiplyArrayItems(arr));

        //    //var result = _services.MultiplyArrayItems(arr);



        //    //ICalculateService calculateService = new CalculateService();

        //    //var result = calculateService.MultiplyArrayItems(arr);
        //    //Console.WriteLine( result);

        //}

         public void SquareOfSumArrayItems() => Console.WriteLine(_services.SquareOfSumArrayItems(GetArr()));
        // {
        //    Console.WriteLine(_services.SquareOfSumArrayItems(GetArr()));


        //    //int[] arr = { 1, 2, 3, 4, 5, 6, 12 };

        //    //var result = GetArr();



        //    //Console.WriteLine(_services.SquareOfSumArrayItems(result));
         
        //    //Console.WriteLine(_services.SquareOfSumArrayItems(arr));


        //    //var result = _services.SquareOfSumArrayItems(arr);

        //    //ICalculateService calculateService = new CalculateService();

        //    //var result = calculateService.SquareOfSumArrayItems(arr);
        //    //Console.WriteLine( result);
        //}

        private int[] GetArr() => new[] { 1, 2, 3, 4, 5, 6, 12 };
        //{
        //    int[] arr = { 1, 2, 3, 4, 5, 6, 12 };
        //    return arr;

        //}


    }
}
