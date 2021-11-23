using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exception_handling_and_Error_handling
{
  public  class Democlass
    {
        public int grandparent(int position)
        {
            int output = 0;
            Console.WriteLine("open data base connection");
            try
            {
                output = parentmethod(position);

            }
            catch (Exception)
            {

                throw;
            }            Console.WriteLine("close data base connection");
            return output;

        }
        public int parentmethod(int position)
        {
            return Getnumber(position);
        }
        public int Getnumber(int position)
        {
            int output = 0;
            try
            {
                int[] numbers = new int[] { 1, 4, 7, 2 };
                output= numbers[position];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);//Index was outside the bounds of the array.

                Console.WriteLine(ex.StackTrace);//  at Exception_handling_and_Error_handling.
                                                 //  Democlass.Getnumber(Int32 position) in
                                                 //  C:\Users\PC\source\repos\Exception handling
                                                 //  and Error handling\Democlass.cs:line 24

            }
            return output;
        }
    }
}
