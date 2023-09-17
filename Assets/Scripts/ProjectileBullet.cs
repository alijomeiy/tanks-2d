using System;
using UnityEngine;

public class ProjectileBullet : Bullet
{
    private Rigidbody2D _rigidbody;
    public Vector2 Force;
    private void Update()
    {
        transform.Rotate(0,0,5);
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