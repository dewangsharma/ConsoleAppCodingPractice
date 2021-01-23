using System;

namespace ConsoleAppCodingPractice.Concepts.DS
{
    internal class DSQueue<T>
    {
        private DSNode<T> head;
        private DSNode<T> tail;

        public DSQueue( )
        {
            head = null;
            tail = null;
        }

        internal void Enqueue( T data )
        {
            var node = new DSNode<T>( data );
            if( tail != null )
            {
                tail.next = node;
            }
            tail = node;
            if( head == null)
            {
                head = node;
            }
        }

        internal T Dequeue( )
        {
            var tempHead = head;

            if( head != null && head.next != null )
            {
                head = head.next;
                return tempHead.data;
            }
            head = null;
            tail = null;
            return default( T );
        }

        internal T Peek( )
        {
            if( head != null )
                return head.data;
            return default( T );
        }
    }

    internal class DSNode<T>
    {
        internal T data;
        internal DSNode<T> next;

        public DSNode( T data )
        {
            this.data = data;
            this.next = null;
        }
    }

    class MyQueue : IStartMain
    {
        public void BootStrap( )
        {
            var queue = new DSQueue<string>();
            queue.Enqueue( "1" );
            queue.Enqueue( "2" );
            queue.Enqueue( "3" );
            queue.Enqueue( "4" );
            queue.Enqueue( "5" );
            queue.Enqueue( "6" );
            Console.WriteLine("Added 1,2,3,4,5,6");
            Console.WriteLine($"Peek { queue.Peek() }");
            Console.WriteLine ($"Remove { queue.Dequeue() }");
            Console.WriteLine( $"Peek { queue.Peek() }" );
            Console.WriteLine( $"Remove { queue.Dequeue() }" );
            Console.WriteLine( $"Peek { queue.Peek() }" );
            Console.WriteLine( $"Remove { queue.Dequeue() }" );
            Console.WriteLine( $"Peek { queue.Peek() }" );


            var personQueue = new DSQueue<QueuePerson>();

            personQueue.Enqueue( new QueuePerson { ID =1, Name = "Sharma 1" } );
            Console.WriteLine( $"Person Queue Peek { personQueue.Peek() }" );

            personQueue.Enqueue( new QueuePerson { ID = 2, Name = "Sharma 2" } );
            Console.WriteLine( $"Person Queue Peek { personQueue.Peek() }" );
            Console.WriteLine( $"Remove { personQueue.Dequeue() }" );

            personQueue.Enqueue( new QueuePerson { ID = 3, Name = "Sharma 3" } );
            Console.WriteLine( $"Person Queue Peek { personQueue.Peek() }" );
            Console.WriteLine( $"Remove { personQueue.Dequeue() }" );

            personQueue.Enqueue( new QueuePerson { ID = 4, Name = "Sharma 4" } );
            Console.WriteLine( $"Person Queue Peek { personQueue.Peek() }" );

            personQueue.Enqueue( new QueuePerson { ID = 5, Name = "Sharma 5" } );
            Console.WriteLine( $"Person Queue Peek { personQueue.Peek() }" );
            Console.WriteLine( $"Remove { personQueue.Dequeue() }" );

            personQueue.Enqueue( new QueuePerson { ID = 6, Name = "Sharma 6" } );
            Console.WriteLine( $"Person Queue Peek { personQueue.Peek() }" );
            Console.WriteLine( $"Remove { personQueue.Dequeue() }" );

            Console.WriteLine( $"Remove { personQueue.Dequeue() }" );
            Console.WriteLine( $"Remove { personQueue.Dequeue() }" );
            Console.WriteLine( $"Remove { personQueue.Dequeue() }" );
            Console.WriteLine( $"Remove { personQueue.Dequeue() }" );
        }
    }

    class QueuePerson 
    {
        public int ID  { get; set; }
        public string Name{ get; set; }

        public override string ToString( )
        {
            return $"{ ID } {Name}";
        }
    }
}
