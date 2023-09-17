using System;
using UnityEngine;

public class TripleProjectileBullet : Bullet
{
    private Rigidbody2D _rigidbody;
    public Vector2 Force;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Shoot(Force);
        }
    } 

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public override void Shoot(Vector2 force)
    {
        _rigidbody.AddForce(force, ForceMode2D.Impulse);
    }
}