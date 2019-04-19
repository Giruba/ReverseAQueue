using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseAQueue
{
    class Queue
    {
        int data;
        int size;
        int capacity;
        int[] queueArray;
        int rear;
        int front;


        private Queue() { }

        public Queue(int capacity) {
            this.capacity = capacity;
            size = 0;
            queueArray = new int[capacity];
            front = 0;
            rear = -1;
        }

        public void Enqueue(int data) {
            if (size == capacity)
            {
                Console.WriteLine("Queue is full! Cannot insert!");
            }
            else {
                size++;
                rear = (rear + 1) % capacity;
                queueArray[rear] = data;
            }
        }

        public int Dequeue() {
            if (size == 0) {
                Console.WriteLine("Queue is empty! Cannot dequeue!");
                return -1;
            }
            int returnValue = queueArray[front];
            front += 1;
            size--;
            return returnValue;
        }

        public int GetQueueCurrentSize() {
            return size;
        }

        public int GetQueueCapacity() {
            return capacity;
        }

        public void SetQueueCurrentSize(int size)
        {
            this.size =  size;
        }

        public void SetQueueCapacity(int capacity)
        {
            this.capacity = capacity;
        }

        public void PrintQueue() {
            for (int i = 0; i < size; i++) {
                Console.Write(this.queueArray[i]+" ");
            }
        }

        public int Peek() {
            return this.queueArray[rear];
        }
    }
}
