using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using ParkingLib;

namespace ParkingApi.Services
{
    public class CarService
    {
        private Parking parking;

        public CarService()
        {
            parking = Parking.Create;
        }

        public async Task<string> GetCar()
        {
            var strData = await Task.Run(() =>
            {
                return JsonConvert.SerializeObject(parking.AllCar);
            });

            return strData;
        }

        public async Task<string> PostCar(string category, int cash)
        {
            var strData = await Task.Run(() =>
            {
                parking.AddCar(category, cash);
                return JsonConvert.SerializeObject(parking.AllCar);
            });

            return strData;
        }

        public async Task<string> DeleteCar(int id)
        {
            var strData = await Task.Run(() =>
            {
                parking.RemoveCar(id);
                return JsonConvert.SerializeObject(parking.AllCar);
            });

            return strData;
        }
    }
}