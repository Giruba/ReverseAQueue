using System;

namespace ReverseAQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******** Reverse a Queue! *********");
            Console.WriteLine("---------------");
            Queue queue = GetQueueFromInput();
            Console.WriteLine("--------The Queue--------");
            queue.PrintQueue();
            Console.WriteLine();
            Console.WriteLine("-------The Reversed Queue-------");
            PrintReversedQueue(queue);
            Console.ReadLine();
        }

        private static Queue GetQueueFromInput() {
            Queue queue = null;

            Console.WriteLine("Enter the number of elements to " +
                " be inserted");
            try
            {
                int numberElements = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the elements separated by " +
                    " space or comma or semi-colon");
                String[] elements = Console.ReadLine().Split(' ', ';', ',');
                queue = new Queue(numberElements);
                for (int i = 0; i < numberElements; i++) {
                    queue.Enqueue(int.Parse(elements[i]));
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            return queue;
        }

        private static void PrintReversedQueue(Queue queue) {
            int noElements = queue.GetQueueCurrentSize();
            Stack stack = new Stack(noElements);
            for (int i = 0; i < noElements; i++) {
                stack.Push(queue.Dequeue());
            }
            queue.SetQueueCurrentSize(0);
            for (int index = 0; index < noElements; index++) {
                queue.Enqueue(stack.Pop());
            }

            queue.PrintQueue();
        }
    }
}
