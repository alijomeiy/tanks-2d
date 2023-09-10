using System;
using UnityEngine;

public class ProjectileBullet : Bullet
{
    public Rigidbody2D _rigidbody;
    public ParticleSystem Effect;
    public float Force = 1;


    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        Shoot(new Vector2(2,2));
    }

    public override void Shoot(Vector2 force)
    {
        _rigidbody.AddForce(force, ForceMode2D.Impulse);
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        Instantiate(Effect,transform.position,Quaternion.identity);
        Destroy(gameObject);
    }
}