using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Laptop
    {
        public CPU cpu;
        public GPU gpu;
        public RAM ram;
        public SSD ssd;

        public Laptop(CPU CPU, GPU GPU, RAM RAM, SSD SSD)
        {
            this.cpu = CPU;
            this.gpu = GPU;
            this.ram = RAM;
            this.ssd = SSD;
        }
        public void Work()
        {
            cpu.OnCPU();
            gpu.OnGPU();
            ram.OnRAM();
            ssd.OnSSD();
        }
        public void DontWork()
        {
            cpu.OffCPU();
            gpu.OffGPU();
            ram.OffRAM();
            ssd.OffSSD();
        }
    }
    public class CPU
    {
        public void OnCPU()
        {
            Console.WriteLine("CPU is ready for work!");
        }

        public void OffCPU()
        {
            Console.WriteLine("CPU off!");
        }
    }
    public class GPU
    {
        public void OnGPU()
        {
            Console.WriteLine("GPU is ready for work");
        }

        public void OffGPU()
        {
            Console.WriteLine("GPU is off");
        }
    }
    public class RAM
    {
        public void OnRAM()
        {
            Console.WriteLine("RAM ready for work!");
        }

        public void OffRAM()
        {
            Console.WriteLine("RAM is off");
        }
    }
    public class SSD
    {
        public void OnSSD()
        {
            Console.WriteLine("SSD is ready for work");
        }

        public void OffSSD()
        {
            Console.WriteLine("SSD is off");
        }
    }
    class User
    {
        public static void ON(Laptop LP)
        {
            LP.Work();
        }
        public static void OFF(Laptop LP)
        {
            LP.DontWork();
        }
    }
    class CheckCode
    {
        static void Main()
        {
            CPU MyCPU = new CPU();
            GPU MyGPU = new GPU();
            RAM MyRAM = new RAM();
            SSD MySSD = new SSD();
            Laptop LP = new Laptop(MyCPU, MyGPU, MyRAM, MySSD);
            Console.WriteLine("Welcome!\nLoading...\n");
            System.Threading.Thread.Sleep(5000);
            User.ON(LP);
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("\n");
            User.OFF(LP);
        }
    }
}
