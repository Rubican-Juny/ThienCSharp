using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismInterface
{
    internal class SomeFile : IBinary, ITextFile
    {
        public void ReadFile() => Console.WriteLine("Read File");

        public void WriteBinaryFile() => Console.WriteLine("write binary file");

        public void WriteTextFille() => Console.WriteLine("write text file");
    }
}
