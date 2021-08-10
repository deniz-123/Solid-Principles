namespace SolidPrinciples.SRP
{
    public class Ball : OCP.Geometry
    {
        public int radius;
        public Ball(int radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return this.radius * this.radius * 3.14 * 4;
        }

        public override double Volume()
        {
            return this.radius * this.radius * this.radius * 3.14 * 4 / 3;
        }
    }
}
