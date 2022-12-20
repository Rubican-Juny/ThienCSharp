using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopEncapsulation
{
    public class Plant
    {
        //chỉ dùng trong class này
        private void Private() => Console.WriteLine("Private ");
        //class con dùng được
        protected void Protected() => Console.WriteLine("Protected");
        //cùng project dùng được
        internal void Internal() => Console.WriteLine("Internal");
        //có cái nào xài cái đó 
        private protected void PrivateProtected() => Console.WriteLine("Private Protected");
        //có cái nào xài cái đó
        protected internal void ProtectedInternal() => Console.WriteLine("Protected Internal");
        public void Public() => Console.WriteLine("Public"); 


        static void Main(string[] args)
        {
            Plant plant = new();
            plant.Private();
            plant.Protected();
            plant.Internal();
            plant.PrivateProtected();
            plant.ProtectedInternal();
            plant.Public();
        } 

    }
}
