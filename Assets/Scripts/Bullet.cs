using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    [SerializeField] private float destructionPower;
    public ParticleSystem Effect;

    public abstract void Shoot(Vector2 force);

    private void  OnCollisionEnter2D(Collision2D other)
    {
        Explode();
        Destroy(gameObject);
    }

    protected virtual void Explode()
    {
        Instantiate(Effect,transform.position,Quaternion.identity);
    }
}