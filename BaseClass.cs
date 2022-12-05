using NUnit.Framework;
using RestAssuredDemoProject.Specifications;

namespace RestAssuredDemoProject
{
    public class BaseClass
    {
        protected RequestSpecifications requestSpecifications;
        
        [SetUp]
        public void Setup()
        {
            requestSpecifications = new RequestSpecifications();
        }
    }
}