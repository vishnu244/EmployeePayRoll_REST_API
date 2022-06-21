using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRoll_REST_API
{
    public class RestShart
    {
        public void givenEmployee_OnPost_ShouldReturnAddedEmployee()
        {
            //arrange
            RestRequest request = new RestRequest("/Employee", Method.Post);
            JObject jobjectbody = new JObject();
            jobjectbody.Add("Name", "Nitesh");
            jobjectbody.Add("Salary", "22000");

            request.AddParameter("application/json", jobjectbody, ParameterType.RequestBody);
            
        }
    }
}
