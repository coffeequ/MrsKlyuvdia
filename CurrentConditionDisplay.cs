using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrsKlyuvdia
{
    class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private bool hit;

        private string educate;

        private string advice;

        private ISubject journalMrsKlyuvdia;

        public CurrentConditionDisplay(ISubject journalMrsKlyuvdia)
        {
            this.journalMrsKlyuvdia = journalMrsKlyuvdia;
            journalMrsKlyuvdia.registerObserver(this);
        }

        public void display()
        {
            System.Windows.MessageBox.Show($"Совет Миссис Клавдии: бить-ли ребёнка: {hit}, обучать ребёнка: {educate}. Совет для ребёнка: {advice} ");
        }

        public void update(bool hit, string educate, string advice)
        {
            this.hit = hit;
            this.educate = educate;
            this.advice = advice;
            display();
        }
    }
}
