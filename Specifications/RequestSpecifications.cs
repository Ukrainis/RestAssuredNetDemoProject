using RestAssured.Request.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAssuredDemoProject.Specifications
{
    public class RequestSpecifications
    {
        public RequestSpecification CreateRequestSpecification(string contentType = "application/json")
        {
            return new RequestSpecBuilder()
                .WithHostName("spring-boot-test-aplication.herokuapp.com")
                .WithBasePath("/api")  
                .WithHeader("accept", contentType)
                .Build();
        }
    }
}
