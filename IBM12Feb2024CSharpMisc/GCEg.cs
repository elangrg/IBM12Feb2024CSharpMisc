using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM12Feb2024CSharpMisc
{
    internal class GCEg
    {
        static void Main()
        {

            using (Employee employee = new Employee())
            {
                 employee.EmpID = 1;
          
            }

                   
            Console.WriteLine(  "After GC");
            Console.ReadKey();

        }
    }

    class Employee:IDisposable
    {
        private bool disposedValue;

        public int EmpID { get; set; }

        ~Employee() {

            Console.WriteLine(  "Fin Destructor Caller !!!");
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~Employee()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }

}
