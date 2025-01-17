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

        // Método para invertir la lista enlazada
        public void Reverse()
        {
            Node<T> prev = null;
            Node<T> current = head;
            Node<T> next = null;

            while (current != null)
            {
                next = current.Next; // Guardar el siguiente nodo
                current.Next = prev; // Invertir la dirección del enlace
                prev = current;      // Mover prev hacia adelante
                current = next;      // Mover current hacia adelante
            }

            head = prev; // Actualizar el encabezado de la lista
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
            linkedList.Add(4);
            linkedList.Add(5);

            Console.WriteLine("Lista original:");
            linkedList.PrintList();

            // Invertir la lista
            linkedList.Reverse();

            Console.WriteLine("Lista invertida:");
            linkedList.PrintList();
        }
    }
}
