using CrudOperation.CommonLayer.Model;
using CrudOperation.RepositoryLayer;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrudOperation.ServiceLayer
{
    public class CrudOperationSL : ICrudOperationSL
    {
        public readonly ICrudOperationRL _crudOperationRL;

        public CrudOperationSL(ICrudOperationRL crudOperationRL)
        {
           _crudOperationRL=crudOperationRL;
        }
        
        public async Task<CreateRecordResponse> CreateRecord(CreateRecordRequest request)
        {
          return await _crudOperationRL.CreateRecord(request);
        }
    }
}