using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockbackSource : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [SerializeField] float knockbackForce;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Movement movement = collision.collider.GetComponent<Movement>();
        if (movement != null)
        {
            Vector3 collisionPoint = collision.GetContact(0).point;
            Vector3 knockback = movement.transform.position - collisionPoint;
            knockback = knockback.normalized;
            knockback *= knockbackForce;
            movement.ApplyKnockback(knockback);
        }
    }
}
