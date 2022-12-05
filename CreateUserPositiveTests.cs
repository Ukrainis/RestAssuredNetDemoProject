using NUnit.Framework;
using RestAssuredDemoProject.DTO;

using static RestAssured.Dsl;

namespace RestAssuredDemoProject
{
    [TestFixture]
    public class CreateUserPositiveTests : BaseClass
    {
        string userName = "TestTikTo1";

        [Test, Order(1)]
        public void CreateUserShouldGet201()
        {
            UserDTO userBody = new UserDTO()
            {
                UserName = userName,
                Name = "Test",
                Email = "test",
                Website = "google.com",
                Phone = "123",
            };

            Given().When().Log().All().Spec(requestSpecifications.CreateRequestSpecification())
                .Body(userBody)
                .ContentType("application/json")
                .When().Post("/user/createUserPost")
                .Then().Log().All()
                .StatusCode(201)
                .ContentType("application/json")
                .Body("id", NHamcrest.Is.GreaterThan(0))
                .Body("userName", NHamcrest.Is.EqualTo(userName));
        }

        [Test, Order(2)]
        public void CheckCreatedUserShouldGet200()
        {
            Given().When().Log().All().Spec(requestSpecifications.CreateRequestSpecification())
                .PathParam("userName", userName)
                .When().Get("/users/findByUserName/{{userName}}")
                .Then().Log().All()
                .StatusCode(200)
                .ContentType("application/json")
                .Body("id", NHamcrest.Is.GreaterThan(0))
                .Body("userName", NHamcrest.Is.EqualTo(userName));
        }

        [Test, Order(3)]
        public void DeleteCreatedUserShouldGet200()
        {
            Given().When().Log().All().Spec(requestSpecifications.CreateRequestSpecification())
                .PathParam("userName", userName)
                .When().Delete("/user/{{userName}}/delete")
                .Then().Log().All()
                .StatusCode(204)
                .Body(NHamcrest.Contains.String(""));
        }
    }
}
