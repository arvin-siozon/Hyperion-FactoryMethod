using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperionV2.Business;
using HyperionV2.Business.Base;
using HyperionV2.Business.BusinessLogic;
using HyperionV2.Business.Dto;
using HyperionV2.Domain.Entities;
using HyperionV2.Domain.Interfaces;

namespace HyperionV2.Console
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
                        var sedanCarCreator = new CarFactory<IHyperionCreator, SedanCreator>();
                        var sedanSpecifications = carRequirements.CreateProductSpecs(hyperion.GetType().Name, 4, 2);
                        var counter = 0;

                        foreach (var productSpec in sedanSpecifications)
                        {
                            counter++;

                            var finishProduct = sedanCarCreator.CreateInstance().HyperionModelCreator(productSpec);
                            ShowProduct(finishProduct, counter);
                            System.Console.WriteLine(sedanCarCreator.StartEngine("Welcome to Hyperion"));
                            System.Console.WriteLine("------------------------------------");
                            System.Console.WriteLine(Environment.NewLine);

                        }

                        break;
                    case "Coupe":

                        var coupCarCreator = new CarFactory<IHyperionCreator, CoupeCreator>();
                        var soupeSpecifications = carRequirements.CreateProductSpecs(hyperion.GetType().Name, 2, 2);
                        counter = 0;

                        foreach (var productSpec in soupeSpecifications)
                        {
                            counter++;

                            var finishProduct = coupCarCreator.CreateInstance().HyperionModelCreator(productSpec);
                            ShowProduct(finishProduct, counter);
                            System.Console.WriteLine(coupCarCreator.StartEngine("Welcome to Hyperion"));
                            System.Console.WriteLine("------------------------------------");
                            System.Console.WriteLine(Environment.NewLine);

                        }

                        break;
                    case "Sport":
                        var sportCarCreator = new CarFactory<IHyperionCreator, SportCreator>();
                        var sportCarSpecifications = carRequirements.CreateProductSpecs(hyperion.GetType().Name, 20, 2, 3);
                        var counter1 = 0;

                        foreach (var productSpec in sportCarSpecifications)
                        {
                            counter1++;

                            var finishProduct = sportCarCreator.CreateInstance().HyperionModelCreator(productSpec);
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
