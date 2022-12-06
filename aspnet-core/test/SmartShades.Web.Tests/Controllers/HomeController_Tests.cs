using System.Threading.Tasks;
using SmartShades.Models.TokenAuth;
using SmartShades.Web.Controllers;
using Shouldly;
using Xunit;

namespace SmartShades.Web.Tests.Controllers
{
    public class HomeController_Tests: SmartShadesWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}