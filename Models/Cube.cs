using System;
namespace SolidPrinciples.Models
{
    public class Cube : OCP.Geometry
    {
        public int length;
        public Cube(int length)
        {
            this.length = length;
        }

        public override double Area()
        {
            return this.length * this.length * 6;
        }

        public override double Volume()
        {
            return this.length * this.length * this.length;
        }
    }
}
