using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Linq;
using WebAppMvc.Business.Repository.Abstract;
using WebAppMvc.Core.Entities;
using WebAppMvc.Core.ViewModels;
using WebAppMvc.Data;
using WebAppMvc.Extentions;

namespace WebAppMvc.Areas.Admin.Controllers
{
    [Route("api/[controller]/[action]")]
    public class SubscriptionTypeApiController : Controller
    {
        private readonly SubscriptionTypeRepo _repo;

        public SubscriptionTypeApiController(SubscriptionTypeRepo repo)
        {
            _repo = repo;
        }

        #region Crud
        [HttpGet]
        public IActionResult Get(DataSourceLoadOptions options)
        {
            var data = _repo.Get();

            return Ok(DataSourceLoader.Load(data, options));
        }
        [HttpGet]
        public IActionResult Detail(Guid id, DataSourceLoadOptions loadOptions)
        {
            var data = _repo.Get(x => x.Id == id);

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
            try
            {
                var result = _repo.Insert(data);
            }
            catch
            {
                return BadRequest(new JsonResponsiveViewModel
                {
                    IsSuccess = false,
                    ErrorMessage = "Yeni üyelik tipi kaydedilemedi."
                });
            }

            return Ok(new JsonResponsiveViewModel());
        }
        [HttpPut]
        public IActionResult Update(Guid key, string values)
        {
            var data = _repo.GetById(key);
            if (data == null)
                return BadRequest(new JsonResponsiveViewModel()
                {
                    IsSuccess = false,
                    ErrorMessage = ModelState.ToFullErrorString()
                });

            JsonConvert.PopulateObject(values, data);
            if (!TryValidateModel(data))
                return BadRequest(ModelState.ToFullErrorString());

            var result = _repo.Update(data);
            if (result == 0)
                return BadRequest(new JsonResponsiveViewModel()
                {
                    IsSuccess = false,
                    ErrorMessage = "Üyelik tipi güncellenemedi"
                });
            return Ok(new JsonResponsiveViewModel());
        }
        [HttpDelete]
        public IActionResult Delete(Guid key)
        {
            var data = _repo.GetById(key);
            if (data == null)
                return StatusCode(StatusCodes.Status409Conflict, "Üyelik tipi bulunamadı");

            var result = _repo.Delete(data.Id);
            if (result == 0)
                return BadRequest("Silme işlemi başarısız");
            return Ok(new JsonResponsiveViewModel());
        }
        #endregion
    }
}
