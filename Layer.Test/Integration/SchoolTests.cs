using Layer.DAL.Entities;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Layer.Test.Integration
{
    internal class SchoolTests
    {
        private const string BASE_PATH = "/api/schools";


        [Test]
        public async Task Should_Create_Schools()
        {
            // arrange
            await using var application = new WebAppFactory("Development");
            var client = application.CreateClient();

            var school1 = new School("school1");
            var school2 = new School("school2");
            var school3 = new School("school3");

            // act
            var response = await client.PostAsync(BASE_PATH, school1.BuildByteContent());

            // Assert
            Assert.IsNotNull(response);
        }
    }
}
