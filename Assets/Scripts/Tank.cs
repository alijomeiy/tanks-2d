using System.Collections.Generic;
using System.Runtime;
using UnityEngine;

public class Tank : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] private List<Bullet> projectiles;
    [SerializeField] public float moveSpeed;
    [SerializeField] public GameObject Turret;
    [SerializeField] public GameObject BulletShootingPointer;
    // private _shootX and _shootY
    public float _shootX;
    public float _shootY;
    //
    
    
    public Rigidbody2D WheelRigidbody2D;
    private float degree;

    public void Move()
    {
        degree = transform.localRotation.eulerAngles.x;
        float xcomponent = Mathf.Cos(degree * Mathf.PI / 180) * moveSpeed;
        float ycomponent = Mathf.Sin(degree * Mathf.PI / 180) * moveSpeed;
        WheelRigidbody2D.transform.position+= new Vector3(xcomponent, ycomponent, 0)*Time.deltaTime;
        
    }

    public void SetShootX(float amount)
    {
        _shootX += amount;
    }

    public void SetShootY(float amount)
    {
        _shootY += amount;
    }

    public void Shoot()
    {
        var lastIndex = projectiles.Count - 1;
        var projectile = projectiles[lastIndex];
        projectiles.RemoveAt(lastIndex);
        projectile.transform.rotation = Turret.transform.rotation;
        projectile.Shoot(new Vector2(_shootX, _shootY), BulletShootingPointer.transform.position);
    }

    public void ChangeHealth(float delta)
    {
        health += delta;
    }

    public void TurretLookAt()
    {   

            Vector3 targetPos = Turret.transform.position + new Vector3(_shootX, _shootY, 0);
            targetPos.z = Turret.transform.position.z;

            Vector3 lookDir = targetPos - Turret.transform.position;
            float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;

            Turret.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
            BulletShootingPointer.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}
