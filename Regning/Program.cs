using System;

namespace Regning
{
    class Program
    {
        static void Main(string[] args)
        {
            int sju = 7;
            int fem = 5;

            fem = fem + sju;
            sju = fem - sju;
            fem = fem - sju;
            Console.WriteLine("Fem har blitt " + fem + ", og sju har blitt " + sju);
        }
    }
}
