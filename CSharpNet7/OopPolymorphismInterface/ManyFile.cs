using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismInterface
{
    internal class ManyFile : IBinary , ITextFile
    {
        internal void WriteBinaryFile()
        {
            throw new NotImplementedException();
        }

        //bỏ đi bỏ từ truy cập , sau đó thêm tên interface
        void IBinary.ReadFile() => Console.WriteLine("Read Binary File");
        void ITextFile.ReadFile() => Console.WriteLine("Read Text File");
        void IBinary.WriteBinaryFile() => Console.WriteLine("write binary file");
        void ITextFile.WriteTextFille() => Console.WriteLine("write text file");
    }
}
