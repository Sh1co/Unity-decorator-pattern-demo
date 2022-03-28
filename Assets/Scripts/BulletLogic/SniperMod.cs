public class SniperMod : BulletTypeDecorator
{
    
    private IBulletType _temp;
    
    
    public SniperMod(IBulletType bulletType) : base(bulletType)
    {
        _temp = bulletType;
    }
    
    public override float GetSpeed()
    {
        return _temp.GetSpeed() * 2.5f;
    }

    public override float GetLifeTime()
    {
        return _temp.GetLifeTime() * 3.0f;
    }
    
    public override string GetName()
    {
        return _temp.GetName() + "With sniper mod";
    }
}
