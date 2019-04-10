/*
 * I, Andrew Panko, student number [000394436], certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 4th, 2019.
 */

using System;
using System.Collections.Generic;

namespace Problem4
{
    /// <summary>
    /// Represents an auction
    /// </summary>
    public class Auction
    {
        abstract class Subject
        {

            private List<Observer> _observers = new List<Observer>();

            public void Attach(Observer observer)
            {
                _observers.Add(observer);
            }

            public void Detach(Observer observer)
            {
                _observers.Remove(observer);
            }

            public void Notify()
            {
                foreach (Observer o in _observers)
                {
                    o.Update();
                }
            }
        }

        class ConcreteSubject : Subject

        {
            private string _subjectState;

            // Gets or sets subject state

            public string SubjectState
            {
                get { return _subjectState; }
                set { _subjectState = value; }
            }
        }

        abstract class Observer

        {
            public abstract void Update();
        }

        class ConcreteObserver : Observer

        {
            private string _name;
            private string _observerState;
            private ConcreteSubject _subject;

            // Constructor

            public ConcreteObserver(
              ConcreteSubject subject, string name)
            {
                this._subject = subject;
                this._name = name;
            }

            public override void Update()
            {
                _observerState = _subject.SubjectState;
                Console.WriteLine("Observer {0}'s new state is {1}",
                  _name, _observerState);
            }

            // Gets or sets subject

            public ConcreteSubject Subject
            {
                get { return _subject; }
                set { _subject = value; }
            }
        }
    }
}


// Check over Week 11 slides.
// This will be requiring the Observer design pattern.