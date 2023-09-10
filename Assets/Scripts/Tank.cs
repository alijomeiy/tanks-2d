using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] private List<Bullet> projectiles;
    [SerializeField] public float moveSpeed;
    private Vector2 _shootDirection;
    private float _shootPower;
    private Rigidbody2D _rigidbody2D;
    
    void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void Move()
    {
        _rigidbody2D.AddForce(Vector3.right*moveSpeed);
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
