using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] private List<Bullet> projectiles;
    [SerializeField] public float moveSpeed;
    private Vector2 _shootDirection;
    private float _shootPower;
    public Rigidbody2D WheelRigidbody2D;
    private float degree;

    public void Move()
    {
        degree = transform.localRotation.eulerAngles.x;
        float xcomponent = Mathf.Cos(degree * Mathf.PI / 180) * moveSpeed;
        float ycomponent = Mathf.Sin(degree * Mathf.PI / 180) * moveSpeed;
        WheelRigidbody2D.transform.position+= new Vector3(xcomponent, ycomponent, 0)*Time.deltaTime;
        
    }

    public void SetShootPower()
    {

    }

    public void SetShootDegree()
    {

    }

    public void Shoot()
    {
        var lastIndex = projectiles.Count - 1;
        var projectile = projectiles[lastIndex];
        projectiles.RemoveAt(lastIndex);
        projectile.Shoot(_shootDirection * _shootPower);
    }

    public void ChangeHealth(float delta)
    {
        health += delta;
    }
}
