using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GluingToGround : MonoBehaviour
{
    private Rigidbody2D rb;
    public float Mangitude;
    private float degree;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {   
        degree = transform.localRotation.eulerAngles.x - 90;
        float xcomponent = Mathf.Cos(degree * Mathf.PI / 180) * Mangitude;
        float ycomponent = Mathf.Sin(degree * Mathf.PI / 180) * Mangitude;
        transform.Translate(new Vector3(xcomponent, ycomponent, 0)*Time.deltaTime);

    }
}
