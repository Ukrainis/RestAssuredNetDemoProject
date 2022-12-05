using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

using static RestAssured.Dsl;

namespace RestAssuredDemoProject
{
    [TestFixture]
    public class GetUserPositiveTests : BaseClass
    {
        [TestCase]
        public void GetUsersJsonShouldGet200()
        {
            Given().Log().All().Spec(requestSpecifications.CreateRequestSpecification())
                .When().Get("/users")
                .Then().Log().All()
                .StatusCode(200)
                .ContentType("application/json");
        }

        [TestCase]
        public void GetUsersXmlShouldGet200()
        {
            Given().Log().All().Spec(requestSpecifications.CreateRequestSpecification("application/xml"))
                .When().Get("/users")
                .Then().Log().All()
                .StatusCode(200)
                .ContentType("application/xml");
        }
    }
}
