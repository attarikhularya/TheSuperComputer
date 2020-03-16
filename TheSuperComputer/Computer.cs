using System;
using System.Collections.Generic;
using System.Text;

namespace TheSuperComputer
{
    class Computer
    {
        private Monitor monitor;
        private Print print;
        private Prosesor prosesor;
        private Ram ram;
        private Vga vga;

        private Computer(Builder builder) 
        {
            this.monitor = builder.monitor;
            this.print = builder.print;
            this.prosesor = builder.prosesor;
            this.ram = builder.ram;
            this.vga = builder.vga;
        }
        public override string ToString()
        {
            return $"Monitor spec : {this.monitor} \n"+
                   $"Prosesor spec : {this.prosesor} \n"+
                   $"Print spec : {this.print} \n"+
                   $"Vga spec : {this.vga} \n"+
                   $"Ram spec : {this.ram} \n";
        }
        public class Builder
        {
            public Monitor monitor;
            public Print print;
            public Prosesor prosesor;
            public Ram ram;
            public Vga vga;

            public Builder(Ram ram,Vga vga,Prosesor prosesor)
            {
                this.ram = ram;
                this.vga = vga;
                this.prosesor = prosesor;
            }
            public  Builder withMonitor(Monitor monitor)
            {
                this.monitor = monitor;
                return this;
            }
            public Builder withPrint(Print print)
            {
                this.print = print;
                return this;
            }
            public Computer build()
            {
                return new Computer(this);
            }
        } 
    }
}
