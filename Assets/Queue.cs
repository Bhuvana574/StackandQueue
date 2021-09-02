using System.Collections;
using System.Collections.Generic;
using System.Text;
using System;

namespace Queues
{


    public class Queue<T>
    {
        List<T> contents = new List<T>();
        //constructor
        public Queue()
        {

        }
        //gets the number of items in stack
        public int Count
        {
            get { return contents.Count; }
        }
        //enqueue method add item to the queue
        public void Enqueue(T item)
        {
            contents.Add(item);
        }
       //dequeue method removes front item from queue and returns it
       public T Dequeue()
        {
            if(contents.Count==0)
            {
                throw new InvalidOperationException("cant remove from queue");

            }
            else
            {
                //retrieve front of queue,remove and return
               T  item = contents[0];
                contents.RemoveAt(0);
                return item;

            }
        }
    }
}
