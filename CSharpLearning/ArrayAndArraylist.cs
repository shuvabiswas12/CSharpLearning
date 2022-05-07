using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning
{
    class ArrayAndArraylist
    {
        public ArrayAndArraylist()
        {
            this.GetJaggedArray();
            this.RectangularArray();
            this.SomeArrayMethod();
        }

        void GetJaggedArray()
        {
            Console.WriteLine();

            /*
             * Example of JaggedArray:
             * 
             * {
             *  {1, 2, 3},
             *  {1, 2, 3, 4, 5},
             *  {1, 2}
             * }
             * 
             */

            var jaggedArray = new int[3][];

            jaggedArray[0] = new int[3];
            jaggedArray[1] = new int[5];
            jaggedArray[2] = new int[2];

            // jagged array
            for (int i=0; i<3; i++)
            {
                for (int j=0; j<jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = j + 1;
                }
            }

            // show the array...
            Console.WriteLine("Jagged Array: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(@"{0} ", jaggedArray[i][j]);
                }
                Console.WriteLine();
            }

        }

        void RectangularArray()
        {
            Console.WriteLine();

            /*
             * Example of RectangularArray:
             * 
             * {
             *  {1, 2, 3, 4, 5},
             *  {1, 2, 3, 4, 5},
             *  {1, 2, 3, 4, 5}
             * }
             * 
             */

            var rectangularArray = new int[3, 5];

            // insert elements into the array...
            for (int i=0; i<3; i++)
            {
                for (int j=0; j<5; j++)
                {
                    rectangularArray[i, j] = j + 1;
                }
            }

            // show the array...
            Console.WriteLine("Rectangular Array: ");
            for (int i=0; i<3; i++)
            {
                for (int j=0; j<5; j++)
                {
                    Console.Write(@"{0} ", rectangularArray[i, j]);
                }
                Console.WriteLine();
            }
        }

        void SomeArrayMethod()
        {
            var myArray = new int[] { 9, 2, 5, 1, 6, 11, 10, 3 };

            // length 
            Console.WriteLine("Length = {0}", myArray.Length);


            // finding index of an element from an array
            Console.WriteLine(Array.IndexOf(myArray, 2));


            // copy an array to another array
            var anotherArray = new int[3];
            Array.Copy(myArray, anotherArray, 3);
            this.ShowArray(anotherArray);


            // clear items from an array
            Array.Clear(myArray, 0, 3);
            this.ShowArray(myArray);

            // sort an array
            Array.Sort(myArray);
            this.ShowArray(myArray);
        }


        // for showing arrays
        void ShowArray(int[] array)
        {
            for (int i=0; i<array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
