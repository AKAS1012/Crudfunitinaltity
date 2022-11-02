using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using CrudOperation.CommonLayer.Model;
using System.Data.SqlClient;

namespace CrudOperation.RepositoryLayer
{
    public class CrudOperationRL : ICrudOperationRL
    {
       public readonly IConfiguration _configuration;
       public readonly SqlConnection _sqlConnection;

       public CrudOperation(IConfiguration configuration)
       {
          _configuration = configuration;
          _sqlConnection = new SqlConnection(_configuration["ConnectionStrings:DBSettingConnection"]);
       }
       public Task<CreateRecordResponse> CreateRecord(CreateRecordRequest request)
        {
          CreateRecordResponse response = new CreateRecordResponse();
          response.IsSuccess = true;
          response.Message = "Successfull";
          try
          {
            string SqlQuery = "Insert into CrudOperationTable(Username, Age) values(@Username, @Age)";
            using(SqlCommand sqlCommand = new SqlCommand(SqlQuery, _sqlconnection))
            {
              sqlCommand.CommandType = System.Data.CommandType.text;
              sqlCommand.CommandTimeout = 180;
              sqlCommand.Parameters.AddWithValue("@Username", request.UserName);
              sqlCommand.Parameters.AddWithValue("@Age", request.Age);
              int status = await sqlCommand.ExcuteNonQueryAsync();
              if (status>=0)
              {
                response.IsSuccess = false;
                response.Message = "Something went worng";
              }
            }
          }
          catch(Exception ex)
          {
            response.IsSuccess = false;
            response.Message = ex.Message;
          }
          finally
          {
             _sqlconnection.Close();
          }
          return response;
        } 
    }
}