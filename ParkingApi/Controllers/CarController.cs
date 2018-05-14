using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ParkingApi.Services;
using ParkingLib;

namespace ParkingApi.Controllers
{
    [Produces("application/json")]
    public class CarController : Controller
    {
        private CarService service {get; set;}
        public CarController(CarService service)
        {
            this.service = service;
        }

        // GET api/GetCars (example)
        [Route("api/GetCars")]
        [HttpGet]
        public async Task<JsonResult> GetAllCar()
        {
            var query = JsonConvert.DeserializeObject<List<Car>>(await service.GetCar());
            return Json(query);
        }

        // GET api/GetCar/1 (example)
        [Route("api/GetCar/{id}")]
        [HttpGet]
        public async Task<JsonResult> GetCarById(int id)
        {
            var query = JsonConvert.DeserializeObject<List<Car>>(await service.GetCar()).Where(x => x.Id == id);
            return Json(query);
        }

        // POST api/PostCar/Bus&100 (example)
        [Route("api/PostCar/{category}&{cash}")]
        [HttpPost]
        public async Task<JsonResult> PostNewCar(string category, int cash)
        {
            try
            {
                await service.PostCar(category, cash);
                return Json(Ok());
            }
            catch(Exception)
            {
                return Json(BadRequest());
            }
        }

        // DELETE api/RemoveCar/1 (example)
        [HttpDelete("api/RemoveCar/{id}")]
        public async Task<JsonResult> DeleteCar(int id)
        {
            try
            {
                await service.DeleteCar(id);
                return Json(Ok());
            }
            catch
            {
                return Json(BadRequest());
            }
        }
    }
}
