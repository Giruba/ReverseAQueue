using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseAQueue
{
    class Stack
    {
        int top;
        int size;
        int capacity;
        int[] stackArray;

        private Stack() { }

        public Stack(int capacity) {
            this.capacity = capacity;
            stackArray = new int[capacity];
            top = -1;
            size = 0;
        }

        public int GetStackCurrentSize() {
            return size;
        }

        public int GetStackCapacity() {
            return capacity;
        }

        public int Peek() {
            if (top == -1) {
                Console.WriteLine("Stack is empty!");
                return -1;
            }
            return stackArray[top];
        }

        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty!");
                return -1;
            }
            int returnValue =  stackArray[top];
            top--;
            return returnValue;
        }

        public void Push(int data) {
            if (size == capacity) {
                Console.WriteLine("Cannot insert! Stack is full!");
                return;
            }
            stackArray[++top] = data;
        }

    }
}
