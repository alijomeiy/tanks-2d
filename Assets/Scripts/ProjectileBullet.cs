using System;
using UnityEngine;

public class ProjectileBullet : Bullet
{
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    // public void Updeta()

    public override void Shoot(Vector2 force, Vector3 BulletPosition)
    {
        _rigidbody.AddForce(force, ForceMode2D.Impulse);
    }
}