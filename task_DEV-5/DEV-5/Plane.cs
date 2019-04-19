using System;

namespace DEV_5
{
    internal class Plane : IFlyable
    {
        private const int startSpeed = 200; //km per hour
        private Point startPoint;
        private Point targetPoint;

        public void FlyTo(Point NewPoint)
        {
            targetPoint = NewPoint;
        }

        public double GetFlyTime()
        {
            var dist = GetDistance(startPoint, targetPoint);
            var avrgSpeed = GetAverageSpeed(dist);
            return dist / avrgSpeed; //hours
        }

        public FlyableObjectType WhoAmI()
        {
            return FlyableObjectType.Plane;
        }

        public double GetDistance(Point sPoint, Point tPoint)
        {
            var x = tPoint.x - sPoint.x;
            var y = tPoint.y - sPoint.y;
            var z = tPoint.z - sPoint.z;
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public double GetAverageSpeed(double distance)
        {
            var finalspeed = startSpeed + distance / 10 * 10;
            return (startSpeed + finalspeed) / 2;
        }
    }
}