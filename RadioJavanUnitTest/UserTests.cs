using RadioJavan.API.Builder;
using RadioJavan.Interfaces;
using Xunit;

namespace RadioJavanUnitTest
{
    public class UserTests
    {
        IRadioJavanApi radioJavanApi;
        public UserTests()
        {
            radioJavanApi = RadioJavanApiBuilder.CreateBuilder().Build();
        }

        [Theory]
        [InlineData("alish.gibson@gmail.com", "123")]
        [InlineData("someusername", "somepassword")]
        public async void Should_Login(string email, string password)
        {
            var result = await radioJavanApi.LoginAsync(email, password);
            Assert.True(result.Value.Success);
        }

        [Theory]
        [InlineData("alish.gibson@gmail.com")]
        public async void Should_ForgotPassword(string email)
        {
            var result = await radioJavanApi.ForgotPasswordAsync(email);
            Assert.True(result.Value.Success);
        }
    }
}
