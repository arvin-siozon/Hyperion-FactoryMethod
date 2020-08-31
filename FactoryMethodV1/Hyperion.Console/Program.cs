using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hyperion.Business.Base;
using Hyperion.Business.Common;
using Hyperion.Business.ProductBusiness;
using Hyperion.Domain.Dto;
using Hyperion.Domain.Entities;
using Hyperion.Domain.Interfaces;

namespace Hyperion.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHyperionCars();
            System.Console.ReadKey();
        }
        static void CreateHyperionCars()
        {
            var carRequirements = new CarProductRequirements();
            
            var hyperions = new List<IHyperion> {new Sedan(), new Coupe(), new Sport()};
            foreach (var hyperion in hyperions)
            {
                switch (hyperion.GetType().Name)
                {
                    case "Sedan":
                        var sedanCarCreator = new CarCreator<SedanCreator, IHyperion, CarSpecificationDto>();
                        var sedanSpecifications = carRequirements.CreateProductSpecs(hyperion.GetType().Name, 4, 2);
                        var counter = 0;

                        foreach (var productSpec in sedanSpecifications)
                        {
                            counter++;

                            var finishProduct = sedanCarCreator.HyperionModelCreator(productSpec);
                            ShowProduct(finishProduct, counter);
                            System.Console.WriteLine(sedanCarCreator.StartEngine("Welcome to Hyperion"));
                            System.Console.WriteLine("------------------------------------");
                            System.Console.WriteLine(Environment.NewLine);

                        }

                        break;
                    case "Coupe":
                       
                        var coupCarCreator = new CarCreator<CoupeCreator, IHyperion, CarSpecificationDto>();
                        var coupeSpecifications = carRequirements.CreateProductSpecs(hyperion.GetType().Name, 2, 2);
                        counter = 0;

                        foreach (var productSpec in coupeSpecifications)
                        {
                            counter++;

                            var finishProduct = coupCarCreator.HyperionModelCreator(productSpec);
                            ShowProduct(finishProduct, counter);
                            System.Console.WriteLine(coupCarCreator.StartEngine("Welcome to Hyperion"));
                            System.Console.WriteLine("------------------------------------");
                            System.Console.WriteLine(Environment.NewLine);

                        }
                 
                        break;
                    case "Sport":
                        var sportCarCreator = new CarCreator<SportCreator, IHyperion, CarSpecificationDto>();
                        var sportCarSpecifications = carRequirements.CreateProductSpecs(hyperion.GetType().Name, 20, 2, 3);
                        var counter1 = 0;

                        foreach (var productSpec in sportCarSpecifications)
                        {
                            counter1++;

                            var finishProduct = sportCarCreator.HyperionModelCreator(productSpec);
                            ShowProduct(finishProduct, counter1);
                            System.Console.WriteLine(sportCarCreator.StartEngine("Sport Mode Engaged"));
                            System.Console.WriteLine("------------------------------------");
                            System.Console.WriteLine(Environment.NewLine);

                        }
                        break;
                }
                
            }
           
            

           
        }

        private static void ShowProduct(IHyperion finishProduct, int productNumber)
        {
            var hasPowerWindows = "";
            System.Console.WriteLine($"{finishProduct.GetType().Name} Product {productNumber} has the following specifications: ");
            System.Console.WriteLine($"Has {finishProduct.Wheels}-inch wheels.");
            System.Console.WriteLine($"Has {finishProduct.Doors} doors.");
            System.Console.WriteLine($"Has {finishProduct.Engine} liter engine capacity.");
            if (!finishProduct.HasPowerWindows)
            {
                hasPowerWindows = " no";
            }
            System.Console.WriteLine($"Has{hasPowerWindows} power windows.");
            System.Console.WriteLine($"Has {finishProduct.Color} color.");
            System.Console.WriteLine("Engine has started!");

        }
       
    }
}
