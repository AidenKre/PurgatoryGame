using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //public GameObject obj;

    [SerializeField] float acceleration;

    [SerializeField] float speed;

    [SerializeField] float slowdownThreshold;

    Rigidbody2D controlledRigidbody;

    [SerializeField] float knockbackResetTime;
    [SerializeField] float knockbackAcceleration;
    float lastKnockbackTime = 0;

    Vector3 currentVelocity;
    Vector3 targetVelocity;
    // Start is called before the first frame update
    void Start()
    {
        controlledRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Vector3 knockback = Vector3.up + Vector3.right;
            knockback = knockback.normalized;
            knockback *= 105;
            ApplyKnockback(knockback);
        }

    }

    public void SetTarget(Vector3 target)
    {

        targetVelocity = target - transform.position;

        if (targetVelocity.magnitude > slowdownThreshold)
        {
            targetVelocity = targetVelocity.normalized * slowdownThreshold;
        }

        targetVelocity *= speed / slowdownThreshold;

        currentVelocity = Vector3.Lerp(currentVelocity, targetVelocity, GetAcceleration() * Time.deltaTime);

        controlledRigidbody.velocity = currentVelocity;

    }

    public void SetTargetDirection(Vector3 direction)
    {
        direction = direction.normalized;
        direction = direction * slowdownThreshold * 2;
        SetTarget(transform.position + direction);
    }

    float GetAcceleration()
    {
        if (Time.time - lastKnockbackTime < knockbackResetTime)
        {
            return knockbackAcceleration;
        }
        return acceleration;
    }



    public void ApplyKnockback(Vector3 direction)
    {
        currentVelocity += direction;
        lastKnockbackTime = Time.time;
    }
}
