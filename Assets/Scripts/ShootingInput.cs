using System;
using UnityEngine;
public class ShootingInput : MonoBehaviour
{
    [SerializeField] private Bullet _bulletPrefab;
    
    
    private void Start()
    {
        _regularBullet = new BaseBullet();
        _specialBullet = new SniperMod(new BaseBullet());
    }
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootBullet(_regularBullet);
        }
        if (Input.GetMouseButtonDown(1))
        {
            ShootBullet(_specialBullet);
        }
    }

    private void ShootBullet(IBulletType bulletType)
    {
        var mousePos = Input.mousePosition;
        var ray = Camera.main.ScreenPointToRay(mousePos);
        var bullet = Instantiate(_bulletPrefab, transform.position, Quaternion.identity);
        bullet.BulletType = bulletType;
        bullet.Direction = ray.direction;
    }


    private IBulletType _regularBullet;
    private IBulletType _specialBullet;
}
