using System;
using UnityEngine;
using UnityEngine.UIElements;

public class TripleProjectileBullet : Bullet
{
    private Rigidbody2D _rigidbody;
    public GameObject Bullet_1;
    public GameObject Bullet_2;
    public GameObject Bullet_3;
    public static Vector2 StaticForce;
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        Shoot(new Vector2(5,5),transform.position);
    }

    public override void Shoot(Vector2 force, Vector3 BulletPosition)
    {
        StaticForce = force;
        GameObject Bullet1 = Instantiate(Bullet_1,BulletPosition,Quaternion.identity);
        GameObject Bullet2 = Instantiate(Bullet_2,BulletPosition,Quaternion.identity);
        GameObject Bullet3 = Instantiate(Bullet_3,BulletPosition,Quaternion.identity);
    }

}