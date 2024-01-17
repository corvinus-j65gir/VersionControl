using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week06.entities;

namespace week06.Abstractions
{
    public interface IToyFactory
    {
        Toy CreateNew();
    }

    public class BallFactory : IToyFactory
    {
        public Toy CreateNew()
        {
            return new Ball();
        }
    }

    public class CarFactory : IToyFactory 
    {
        public Toy CreateNew() 
        {
            return new Car();
        }
    }
}
