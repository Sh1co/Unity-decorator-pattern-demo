public class BulletTypeDecorator : IBulletType
{
    private IBulletType _temp;

    public BulletTypeDecorator(IBulletType bulletType)
    {
        _temp = bulletType;
    }
    
    public virtual float GetSpeed()
    {
        return _temp.GetSpeed();
    }

    public virtual float GetLifeTime()
    {
        return _temp.GetLifeTime();
    }

    public virtual string GetName()
    {
        return _temp.GetName();
    }
}
