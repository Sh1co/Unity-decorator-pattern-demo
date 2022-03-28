public class SniperMod : BulletTypeDecorator
{
    
    private IBulletType _temp;
    
    
    public SniperMod(IBulletType bulletType) : base(bulletType)
    {
        _temp = bulletType;
    }
    
    public float GetSpeed()
    {
        return _temp.GetSpeed() * 1.5f;
    }

    public float GetLifeTime()
    {
        return _temp.GetLifeTime() * 2.0f;
    }
}
