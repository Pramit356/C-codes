using System;
using System.Text;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {

        public static void Main()
        {
            Console.Write("Enter the dimensions of a house: ");
            string[] dimensions = Console.ReadLine().Split();

            int l = int.Parse(dimensions[0]);
            int w = int.Parse(dimensions[1]);
            int h = int.Parse(dimensions[2]);

            House h1 = new House();

            h1.length = 100;
            h1.width = w;
            h1.height = h;


            Console.WriteLine(h1.length);
            Console.WriteLine(h1.width);
            Console.WriteLine(h1.height);

            long area = h1.getDimensions();

            Console.WriteLine("Area = " + area);
        }
    }


    class House
    {
        private int _length, _width, _height;
        public int length {
            get
            {
                return this._length;
            }

            set
            {
                if (value < 0)
                    throw new Exception("Length cannot be negative");

                if (value > 10000)
                    throw new Exception("This has to be a joke. No house is so big!");

                this._length = value;
            }
        }

        public int width
        {
            get
            {
                return this._width;
            }

            set
            {
                if (value < 0)
                    throw new Exception("Width cannot be negative");

                if (value > 10000)
                    throw new Exception("This has to be a joke. No house is so big!");

                if (Math.Abs(length - value) > 5000)
                    throw new Exception("Invalid proportions");

                this._width = value;
            }
        }
        public int height
        {
            get
            {
                return this._height;
            }

            set
            {
                if (value < 0)
                    throw new Exception("Height cannot be negative");

                if (value > 10000)
                    throw new Exception("This has to be a joke. No house is so big!");

                this._height = value;
            }
        }
        
        public long getDimensions()
        {
            return this._length * this._width;
        }
    }
}
