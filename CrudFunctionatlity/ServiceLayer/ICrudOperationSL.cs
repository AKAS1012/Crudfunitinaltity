using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using CrudOperation.CommonLayer.Model;

namespace CrudOperation.ServiceLayer
{
    public interface ICrudOperationSL
    {
        public Task<CreateRecordResponse> CreateRecord(CreateRecordRequest request);
    }
}