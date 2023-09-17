using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class LighitngBullet : Bullet
{
    public ParticleSystem thunder;
    public GameObject Bullet;


    public override void Shoot(Vector2 force, GameObject ShotPoint)
    {
        GameObject projectile = Instantiate(Bullet,ShotPoint.transform.position, ShotPoint.transform.rotation);
        projectile.GetComponent<Rigidbody2D>().AddForce(force, ForceMode2D.Impulse);
        Debug.Log("LightningShoot");
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        Instantiate(thunder,transform.position,Quaternion.identity);
        Destroy(gameObject);
    }
}