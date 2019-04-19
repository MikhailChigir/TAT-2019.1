using System;

namespace DEV_5
{
    internal class SpaceShip : IFlyable
    {
        private const double speed = 8000; //km/sec
        public Point startPoint { get; set; }
        public Point targetPoint { get; set; }

        public void FlyTo(Point NewPoint)
        {
            targetPoint = NewPoint;
        }

        public FlyableObjectType WhoAmI()
        {
            return FlyableObjectType.SpaceShip;
        }

        public double GetFlyTime()
        {
            var x = startPoint.x - targetPoint.x;
            var y = startPoint.y - targetPoint.y;
            var z = startPoint.z - targetPoint.z;
            var distance = Math.Sqrt(x * x + y * y + z * z);
            var time = distance / (speed * 3600);
            return time;
        }
    }
}