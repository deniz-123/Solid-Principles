using System;
using System.Collections.Generic;

namespace SolidPrinciples.SRP
{
    public class Bucket
    {
        public static List<Ball> bucket;
        public Bucket()
        {
            bucket = new List<Ball>();
        }

        public bool AddBall(Ball ball)
        {
            try
            {
                bucket.Add(ball);
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                return false;
            }
        }
    }
}
