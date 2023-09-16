using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneBullet : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    public float add;
    public ParticleSystem Effect;

    void OnEnable()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.AddForce(TripleProjectileBullet.StaticForce*add, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag != "Bullet")
        {
            Instantiate(Effect,transform.position,Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
