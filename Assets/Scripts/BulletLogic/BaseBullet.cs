public class BaseBullet : IBulletType
{
    public float GetSpeed()
    {
        return 5.0f;
    }

    public float GetLifeTime()
    {
        return 5.0f;
    }

    public string GetName()
    {
        return "BaseBullet";
    }
}
