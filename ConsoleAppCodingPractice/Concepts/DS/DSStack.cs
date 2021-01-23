using System;

namespace ConsoleAppCodingPractice.Concepts.DS
{
    class DSStack<T>
    {
        SNode<T> bottom;
        SNode<T> top;

        internal void Push( T data )
        {
            var node = new SNode<T>( data );
            if( top == null )
            {
                this.top = node;
            }
            else
            {
                var tempTop = this.top;
                this.top = node;
                this.top.previous = tempTop;
            }
            if( bottom == null )
            {
                this.bottom = node;
            }
        }

        internal T Pop( )
        {
            if( top != null && top.previous != null )
            {
                var tempTop = top;
                top = tempTop.previous;
                return tempTop.data;
            }
            if( bottom != null )
            {
                top = null;
                bottom = null;
                return bottom.data;
            }
            return default( T );
        }

        internal T Peek( )
        {
            if( top != null )
            {
                return top.data;
            }
            return default(T);
        }
    }

    class SNode<T>
    {
        internal T data;
        internal SNode<T> previous;
        public SNode( T data )
        {
            this.data = data;
            this.previous = null;
        }
    }

    class MyStack : IStartMain
    {
        public void BootStrap( )
        {
            var stack = new DSStack<int>();
            stack.Push( 1 );
            stack.Push( 2 );
            stack.Push( 3 );
            stack.Push( 4 );
            stack.Push( 5 );
            stack.Push( 6 );
            stack.Push( 7 );
            stack.Push( 8 );
            stack.Push( 9 );
            Console.WriteLine( $"Items added to stack: 1,2,3,4,5,6,7,8,9" );

            Console.WriteLine( $"Removed { stack.Pop() }" );
            Console.WriteLine( $"Peek {stack.Peek()}" );

            Console.WriteLine( $"Removed { stack.Pop() }" );
            Console.WriteLine( $"Peek {stack.Peek()}" );

            Console.WriteLine( $"Removed { stack.Pop() }" );
            Console.WriteLine( $"Peek {stack.Peek()}" );

            Console.WriteLine( $"Removed { stack.Pop() }" );
            Console.WriteLine( $"Peek {stack.Peek()}" );

            Console.WriteLine( $"Removed { stack.Pop() }" );
            Console.WriteLine( $"Peek {stack.Peek()}" );

            Console.WriteLine( $"Removed { stack.Pop() }" );
            Console.WriteLine( $"Peek {stack.Peek()}" );

            Console.WriteLine( $"Adding 100" );
            stack.Push( 100 );
            Console.WriteLine( $"Peek {stack.Peek()}" );
        }
    }
}
