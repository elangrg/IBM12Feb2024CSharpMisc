using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM12Feb2024CSharpMisc
{
    internal class ExceptionHandling
    {
        static void Main(string[] args)
        {

			try
			{
                int i = 0;

                  try
                {
                   Console.Write(  "Enter Number :");
                 i = int.Parse(Console.ReadLine());
                Console.WriteLine(  i);
                }

                catch (FormatException e)
                {

                    Console.WriteLine(" Only Numeric ... " + e.Message);
                    Console.ReadKey();

                    throw new NullReferenceException("Null Ref Error ", e);

                }
                finally { Console.WriteLine("Finally Inner"); }


                Console.WriteLine( $"Value of i={i}" );

            }
			
        catch (OverflowException e)
			{

                Console.WriteLine( " number too Long ... " +  e.Message );
                Console.ReadKey();
            }
        catch (Exception e)
			{

                Console.WriteLine( " Error Occured   " +  e.ToString() );
                Console.ReadKey();
            }
            finally { Console.WriteLine("Finally Outter"); }

            Console.ReadKey();

        }
    }
}
