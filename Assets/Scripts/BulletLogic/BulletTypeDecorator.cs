public class BulletTypeDecorator : IBulletType
{
    private IBulletType _temp;

    public BulletTypeDecorator(IBulletType bulletType)
    {
        _temp = bulletType;
    }
    
    public float GetSpeed()
    {
        return _temp.GetSpeed();
    }

    public float GetLifeTime()
    {
        return _temp.GetLifeTime();
    }
}
