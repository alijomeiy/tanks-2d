using System;
using Unity.Mathematics;
using UnityEngine;

public class LighitngBullet : Bullet
{
    private Rigidbody2D _rigidbody;
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Spawn(GameObject Bullet1,Vector3 Position)
    {
        GameObject Bullet = Instantiate(Bullet1,Position,Quaternion.identity);
    }

    public override void Shoot(Vector2 force)
    {
        _rigidbody.AddForce(force, ForceMode2D.Impulse);
        Vector3 Position = transform.position;
        Spawn(gameObject,Position*20);
        Spawn(gameObject,Position*40);
        Spawn(gameObject,Position*60);
        Spawn(gameObject,Position*80);
    }
}