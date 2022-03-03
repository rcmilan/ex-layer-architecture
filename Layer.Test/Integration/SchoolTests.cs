using Layer.DAL.Entities;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Layer.Test.Integration
{
    internal class SchoolTests
    {
        private const string BASE_PATH = "/api/Schools";

        [Test]
        public async Task Should_Create_Schools()
        {
            // arrange
            await using var application = new WebAppFactory("Development");
            var client = application.CreateClient();

            var schoolRequest = new School("school1");

            // act
            var post = await client.PostAsync(BASE_PATH, schoolRequest.BuildByteContent());

            var postResponse = await post.DeserializeContentAsync<School>();

            var get = await client.GetAsync(BASE_PATH + "/" + postResponse.Id);

            var getResponse = await get.DeserializeContentAsync<School>();

            // Assert
            Assert.AreEqual(postResponse.Id, getResponse.Id);
        }
    }
}