using System;

namespace LinkedListExample
{
    // Clase Nodo
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    // Clase Lista Enlazada
    public class LinkedList<T>
    {
        private Node<T> head;

        // Método para agregar un nuevo nodo al final de la lista
        public void Add(T data)
        {
            var newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                var current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        // Método de búsqueda
        public int Search(T value)
        {
            var current = head;
            int count = 0;

            while (current != null)
            {
                if (current.Data.Equals(value))
                {
                    count++;
                }
                current = current.Next;
            }

            if (count == 0)
            {
                Console.WriteLine($"El dato '{value}' no fue encontrado en la lista.");
            }
            else
            {
                Console.WriteLine($"El dato '{value}' se encuentra {count} vez/veces en la lista.");
            }

            return count;
        }

        // Método para imprimir la lista
        public void PrintList()
        {
            var current = head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList<int>();

            // Agregar elementos a la lista
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(2);
            linkedList.Add(4);

            Console.WriteLine("Lista enlazada:");
            linkedList.PrintList();

            // Buscar un elemento en la lista
            Console.WriteLine("\nBuscando el número 2:");
            linkedList.Search(2);

            Console.WriteLine("\nBuscando el número 5:");
            linkedList.Search(5);
        }
    }
}
