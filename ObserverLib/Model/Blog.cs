using ObserverLib.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLib.Model
{
    public class Blog : ISubject
    {
        private readonly List<IObserver> _observers;
        private Post _post;

        public Blog()
        {
            _observers = new List<IObserver>();            
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(_post);
            }
        }

        public void AddPost(Post post)
        {
            _post = post;
            Notify();
        }
    }
}
