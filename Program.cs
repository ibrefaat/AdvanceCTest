using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalTestAdvancedC
{
    class Program
    {
        static void Main(string[] args)
        {
            student firstStudent = new student();
            Proadcast myprod = new Proadcast();
            myprod.OnAnnounce += firstStudent.Announcemnet;
            myprod.Announce();

        }

       
    }

    public class GenericCollection<T> where T : struct
    {
        private List<T> _Collection;

        public void Add(T item)
        {
            _Collection.Add(item);
        }

        public T this[int i]
        {
            get { return _Collection[i]; }

        }

        public List<T> Sort()
        {
            return  _Collection.OrderByDescending<T>();
        }
    }




    public class student
    {
        public void Announcemnet(object sender , AnnounceEventArg e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public class Proadcast
    {
        public event EventHandler<AnnounceEventArg> OnAnnounce;

        public void Announce()
        {
            if (OnAnnounce != null)
            {
                OnAnnounce(this, new AnnounceEventArg("This is Final exam"));
            }

        }
    }

    public class AnnounceEventArg : EventArgs
    {
        public string Message { get; set; }
        public AnnounceEventArg(string messge)
        {
            Message = messge;
        }
    }
}
