using System;
using Unity.Mathematics;
using UnityEngine;

public class LighitngBullet : Bullet
{
    public Rigidbody2D _rigidbody;
    public ParticleSystem Effect;
    public GameObject Bullet;
    public float Force = 5;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        Shoot(new Vector2(20,20));
    }

    private void Spawn(GameObject Bullet1,Vector3 Position)
    {
        Instantiate(Bullet1,Position,Quaternion.identity);
    }

    public override void Shoot(Vector2 force)
    {
        _rigidbody.AddForce(force, ForceMode2D.Impulse);
        Vector3 Position = transform.position;
        Spawn(Bullet,Position*20);
        Spawn(Bullet,Position*40);
        Spawn(Bullet,Position*60);
        Spawn(Bullet,Position*80);
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        Instantiate(Effect,transform.position,Quaternion.identity);
        Destroy(gameObject);
    }
}