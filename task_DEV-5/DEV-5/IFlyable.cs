namespace DEV_5
{
    internal interface IFlyable
    {
        void FlyTo(Point NewPoint);
        FlyableObjectType WhoAmI();
        double GetFlyTime();
    }
}