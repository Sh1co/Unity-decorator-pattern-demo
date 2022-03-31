using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public IBulletType BulletType;
    public Vector3 Direction;


    private void Start()
    {
        Debug.Log("Shot " + BulletType.GetName());
    }

    private void Update()
    {
        transform.Translate(Direction * BulletType.GetSpeed() * Time.deltaTime);
        _lifeTimeCounter += Time.deltaTime;

        if (_lifeTimeCounter >= BulletType.GetLifeTime())
        {
            Destroy(gameObject);
        }
    }


    private float _lifeTimeCounter = 0;
}
