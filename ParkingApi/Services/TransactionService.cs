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
    public class TransactionsService
    {
        private Parking parking;

        public TransactionsService()
        {
            parking = Parking.Create;
        }

        public async Task<string> GetTransaction()
        {
            var strData = await Task.Run(() =>
            {
                return JsonConvert.SerializeObject(parking.GetAllTransactions());
            });

            return strData;
        }


        public async Task<string> PutTransaction(int id, int cash)
        {
            var strData = await Task.Run(() =>
            {
                return JsonConvert.SerializeObject(parking.AddCash(id, cash));
            });

            return strData;
        }
    }
}