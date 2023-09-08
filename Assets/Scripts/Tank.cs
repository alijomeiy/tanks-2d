using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] private List<Bullet> projectiles;
    [SerializeField] private float moveSpeed;
    private Vector2 _shootDirection;
    private float _shootPower;

    public void Move()
    {
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
