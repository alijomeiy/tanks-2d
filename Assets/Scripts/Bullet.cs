using UnityEngine;
using UnityEngine.UIElements;

public abstract class Bullet : MonoBehaviour
{
    public abstract void Shoot(Vector2 force, GameObject ShotPoint);

    private void OnCollisionEnter2D(Collision2D other)
    {
        Explode();
    }

    protected virtual void Explode()
    {
        // TODO: implement explode
    }
}