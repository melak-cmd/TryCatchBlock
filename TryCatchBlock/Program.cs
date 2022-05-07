#region Name Spaces

using System;
using System.Diagnostics;

#endregion

namespace TryCatchBlock
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (var j = 0; j < 10; j++)
            {
                var w = new Stopwatch();
                double d = 0;
                w.Start();
                for (var i = 0; i < 10000000; i++)
                {
                    d = Math.Sin(d);
                    d = Math.Sin(d);
                }
               

                w.Stop();
                Console.Write("With : try/catch/finally: ");
                Console.WriteLine(w.ElapsedMilliseconds);
                w.Reset();
                d = 0;
                w.Start();

                for (var i = 0; i < 10000000; i++)
                {
                    try
                    {
                        d = Math.Sin(d);
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    finally
                    {
                        d = Math.Sin(d);
                    }
                }

                w.Stop();
                Console.Write("Without : try/catch/finally: ");
                Console.WriteLine(w.ElapsedMilliseconds);
                Console.WriteLine();
            }
        }
    }
}