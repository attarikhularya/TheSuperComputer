using System;

namespace TheSuperComputer
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitor lgMonitor = new Monitor("1200x600", true, 32);
            Print hpPrint = new Print("HP", "MP102", 50);

            Vga nvidaVga = new Vga("Nvidia", 2054, 2054);
            Ram samsungRam = new Ram("DDR4", 5000, 8000);
            Prosesor intelProsesor = new Prosesor();
            intelProsesor.setCache(254);
            intelProsesor.setCore(8);
            intelProsesor.setSeries("CORE i7 8th Gen");

            Computer computer = new Computer.Builder(samsungRam, nvidaVga, intelProsesor)
                .withMonitor(lgMonitor)
                .withPrint(hpPrint)
                .build();
            Console.WriteLine(computer.ToString());
        }
    }
}
