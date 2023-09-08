using System;
using UnityEngine;

public class ProjectileBullet : Bullet
{
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public override void Shoot(Vector2 force)
    {
        _rigidbody.AddForce(force, ForceMode2D.Impulse);
    }
}