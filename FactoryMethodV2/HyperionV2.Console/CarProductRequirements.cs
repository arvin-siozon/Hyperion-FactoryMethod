using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperionV2.Business.Common;
using HyperionV2.Business.Dto;

namespace HyperionV2.Console
{
    public class CarProductRequirements
    {
        public List<CarSpecificationDto> CreateProductSpecs(string carModelName, int doors, double engine)
        {
            var product = new List<CarSpecificationDto>();
            if (GetModelName(carModelName)) return product;
            var redProduct = new CarSpecificationDto
            {
                Doors = doors,
                Engine = engine,
                HasPowerWindows = true,
                Wheels = 18,
                Color = ColorOptions.Red()
            };
            product.Add(redProduct);
            var whiteProduct = new CarSpecificationDto
            {
                Doors = doors,
                Engine = engine,
                HasPowerWindows = true,
                Wheels = 18,
                Color = ColorOptions.White()
            };
            product.Add(whiteProduct);
            var blackProduct = new CarSpecificationDto
            {
                Doors = doors,
                Engine = engine,
                HasPowerWindows = true,
                Wheels = 18,
                Color = ColorOptions.Black()
            };
            product.Add(blackProduct);

            return product;
        }
        public List<CarSpecificationDto> CreateProductSpecs(string carModelName, int wheels, int doors, double engine)
        {
            var product = new List<CarSpecificationDto>();

            var redProduct = new CarSpecificationDto
            {
                Doors = doors,
                Engine = engine,
                HasPowerWindows = true,
                Wheels = wheels,
                Color = ColorOptions.Red()
            };
            product.Add(redProduct);
            var whiteProduct = new CarSpecificationDto
            {
                Doors = doors,
                Engine = engine,
                HasPowerWindows = true,
                Wheels = wheels,
                Color = ColorOptions.White()
            };
            product.Add(whiteProduct);
            var blackProduct = new CarSpecificationDto
            {
                Doors = doors,
                Engine = engine,
                HasPowerWindows = true,
                Wheels = wheels,
                Color = ColorOptions.Black()
            };
            product.Add(blackProduct);

            if (!GetModelName(carModelName)) return product;
            var blueProduct = new CarSpecificationDto
            {
                Doors = doors,
                Engine = engine,
                HasPowerWindows = true,
                Wheels = wheels,
                Color = ColorOptions.Blue()
            };
            product.Add(blueProduct);
            return product;
        }
        public virtual bool GetModelName(string carModelName)
        {
            //make it overridable so in the future if the requirement changes to another hyperion model this base class can be extendable
            return carModelName.ToLower() == "sport";
        }
    }
}
