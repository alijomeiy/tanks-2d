using UnityEngine;

public class TripleBullet : Bullet
{
    private Rigidbody2D _rigidbody;
    public Vector2 Force;
    public bool Spawn;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Shoot(Force);
        }
    } 

    public override void Shoot(Vector2 force)
    {
        Spawn = true;
        _rigidbody.AddForce(force, ForceMode2D.Impulse);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (Spawn == true)
        {
            Spawn = false;
            Instantiate(gameObject, new Vector3(transform.position.x+4,transform.position.y+60,transform.position.z),Quaternion.identity);
            Instantiate(gameObject, new Vector3(transform.position.x+8,transform.position.y+65,transform.position.z),Quaternion.identity);
            Instantiate(gameObject, new Vector3(transform.position.x+12,transform.position.y+70,transform.position.z),Quaternion.identity);
        }    
        Destroy(gameObject);
        Explode();
    } 
    
}