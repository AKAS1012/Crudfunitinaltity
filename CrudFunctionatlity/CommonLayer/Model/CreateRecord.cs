using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrudOperation.CommonLayer.Model
{
    public class CreateRecordRequest
    {
      public string UserName {get; set;}
      public int Age {get;set;}
    }
    public class CreateRecordResponse
    {
       public bool IsSuccess {get; set;}
       public string Message {get;set;}
    }
}