using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using project_v2.Models;
namespace project_v2.Controllers.ApiController
{
    [ApiController]
    [Route("Api/[controller]")]
    public class StoreController : ControllerBase
    {
        private readonly IStoreRePo _repository;
        public StoreController(IStoreRePo repository){
            _repository = repository;
        }
        [HttpGet]
        public ActionResult <IEnumerable<Store>> GetAllStore()
        {
            var storeItems = _repository.GetAllStore();
            return Ok(storeItems);
        }
        [HttpGet("{id}")]
        public ActionResult <IEnumerable<Store>> GetStoreById(int id)
        {
            var storeItem = _repository.GetStoreByID(id);
            return Ok(storeItem);
        }
    }
}