using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudOperation.CommonLayer.Model;
using CrudOperation.ServiceLayer;

namespace CrudOperation.Controllers
{
   [Route("api/[controllre]")]
   [ApiController]
   public class CrudOperationController : ControllerBase
   {
     public readonly ICrudOperationSL _crudOperationSL;
     public CrudOperationController(ICrudOperationSL crudOperationSL)
     {
        _crudOperationSL = crudOperationSL;
     }
     [HttpPost]
     [Route("CreateRecord")]
     public async Task<IActionResult> CreateRecord(CreateRecordRequest request)
     {
        CreateRecordResponse response = null;
        try
        {
            response = await _crudOperationSL.CreateRecord(request);
        }
        catch (Exception ex)
        {
          response.IsSuccess=false;
          response.Message = ex.Message;
        }
        return Ok(response);
     }
   } 
}
