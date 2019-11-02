using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour
{
    Rigidbody rb;
    float force=-10f;
    bool collide = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (!collide)
        {
            rb.AddForce(transform.forward * force, ForceMode.Impulse);
            rb.AddForce(transform.up * force, ForceMode.Acceleration);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("walls") || collision.gameObject.tag.Equals("lamps"))
        {
            Destroy(gameObject);
            collide=true;
        }
    }
}
