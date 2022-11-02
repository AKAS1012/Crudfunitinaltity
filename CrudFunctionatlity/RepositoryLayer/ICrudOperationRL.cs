using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using CrudOperation.CommonLayer.Model;

namespace CrudOperation.RepositoryLayer
{
    public interface ICrudOperationRL
    {
        public Task<CreateRecordResponse> CreateRecord(CreateRecordRequest request);
    }
}