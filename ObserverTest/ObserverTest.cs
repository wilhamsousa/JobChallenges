using ObserverLib.Model;
using Xunit.Abstractions;

namespace ObserverTest
{
    /// <summary>
    /// Subject contains observer list
    /// Observers apply subscription into Subject
    /// Subject notify all Observers in your list
    /// </summary>
    public class ObserverTest
    {
        private readonly ITestOutputHelper _output;

        public ObserverTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void Test1()
        {
            var user1 = new User() { FullName = "User1"};
            var user2 = new User() { FullName = "User2"};
            var user3 = new User() { FullName = "User3"};
            
            var blog = new Blog();
            blog.Attach(user1);
            blog.Attach(user2);
            blog.Attach(user3);

            var post = new Post() { Id = 1, Description = "Post 1", PublicationTime = DateTime.Now, Title = "My post1 title" };
            blog.AddPost(post);

            post = new Post() { Id = 1, Description = "Post 2", PublicationTime = DateTime.Now, Title = "My post2 title" };
            blog.AddPost(post);

            foreach (var item in user1.GetReceivedPosts())
                _output.WriteLine(item);

            foreach (var item in user2.GetReceivedPosts())
                _output.WriteLine(item);

            foreach (var item in user3.GetReceivedPosts())
                _output.WriteLine(item);

            Assert.Equal(2, user1.GetReceivedPosts().Count());
            Assert.Equal(2, user2.GetReceivedPosts().Count());
            Assert.Equal(2, user3.GetReceivedPosts().Count());
        }
    }
}