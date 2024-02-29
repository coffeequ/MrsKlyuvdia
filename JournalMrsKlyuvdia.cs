using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrsKlyuvdia
{
    class JournalMrsKlyuvdia : ISubject
    {
        private List<IObserver> observers;

        private bool hit;

        private string educate;

        private string advice;

        public JournalMrsKlyuvdia()
        {
            observers = new List<IObserver>();
        }

        public void notifyObserver()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                IObserver observer = observers[i];
                observer.update(hit, educate, advice);
            }
        }

        public void registerObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void journalChanged()
        {
            notifyObserver();
        }

        public void setJournal(bool hit, string educate, string advice)
        {
            this.hit = hit;
            this.educate = educate;
            this.advice = advice;
            journalChanged();
        }
    }
}
