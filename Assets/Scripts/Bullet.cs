using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    [SerializeField] private float destructionPower;

    public abstract void Shoot(Vector2 force);

    private void OnCollisionEnter2D(Collision2D other)
    {
        Explode();
    }

    protected virtual void Explode()
    {
        // TODO: implement explode
    }
}