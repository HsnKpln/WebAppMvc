using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Linq;
using WebAppMvc.Data;
using WebAppMvc.Extentions;
using WebAppMvc.Models.Entities;
using WebAppMvc.Views;

namespace WebAppMvc.Areas.Admin.Controllers
{    
    [Route("api/[controller]/[action]")]
    public class SubscriptionTypeApiController : Controller
    {
        private readonly MyContext _dbContext;
        public SubscriptionTypeApiController(MyContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Get(DataSourceLoadOptions options)
        {
            var data = _dbContext.subscriptionTypes;
            return Ok(DataSourceLoader.Load(data,options));
        }
        [HttpGet]
        public IActionResult Detail(Guid id,DataSourceLoadOptions loadOptions)
        {
            var data = _dbContext.subscriptionTypes.Where(x => x.Id == id);

            return Ok(DataSourceLoader.Load(data, loadOptions));
        }
        [HttpPost]
        public IActionResult Insert(string values)
        {
            var data = new SubscriptionType();
            JsonConvert.PopulateObject(values, data);

            if (!TryValidateModel(data))
                return BadRequest(new JsonResponsiveViewModel()
                {
                    IsSuccess = false,
                    ErrorMessage = ModelState.ToFullErrorString()
                });
            _dbContext.subscriptionTypes.Add(data);

            var result = _dbContext.SaveChanges();
            if (result == 0)
                return BadRequest(new JsonResponsiveViewModel
                {
                    IsSuccess = false,
                    ErrorMessage = "Yeni üyelik tipi kaydedilemedi."
                });
            return Ok(new JsonResponsiveViewModel());
        }
        [HttpPut]
        public IActionResult Update(Guid key, string values)
        {
            var data = _dbContext.subscriptionTypes
                .Find(key);
            if (data == null)
                return BadRequest(new JsonResponsiveViewModel()
                {
                    IsSuccess = false,
                    ErrorMessage = ModelState.ToFullErrorString()
                });

            JsonConvert.PopulateObject(values, data);
            if (!TryValidateModel(data))
                return BadRequest(ModelState.ToFullErrorString());

            var result = _dbContext.SaveChanges();
            if (result == 0)
                return BadRequest(new JsonResponsiveViewModel()
                {
                    IsSuccess = false,
                    ErrorMessage = "Yeni üyelik güncellenemedi"
                });
            return Ok(new JsonResponsiveViewModel());
        }
        [HttpDelete]
        public IActionResult Delete(Guid key)
        {
            var data = _dbContext.subscriptionTypes.Find(key);
            if (data == null)
                return StatusCode(StatusCodes.Status409Conflict, "Yeni üyelik tipi bulunamadı");

            _dbContext.subscriptionTypes.Remove(data);

            var result = _dbContext.SaveChanges();
            if (result == 0)
                return BadRequest("Silme işlemi başarısız");
            return Ok(new JsonResponsiveViewModel());
        }
    }
}
