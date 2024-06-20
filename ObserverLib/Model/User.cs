using Microsoft.VisualBasic;
using ObserverLib.Interface;

namespace ObserverLib.Model
{
    public class User : IObserver
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        private readonly List<string> _receivedPosts = new List<string>();

        public void Update(object obj)
        {
            var post = (Post)obj;
            _receivedPosts.Add($"User {FullName} Received: FullName {FullName} - new post:`{post.Title}");
        }

        public IEnumerable<string> GetReceivedPosts() => _receivedPosts;
    }
}
