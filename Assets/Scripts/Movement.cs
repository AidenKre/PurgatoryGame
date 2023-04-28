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

    Vector3 currentVelocity;
    Vector3 targetVelocity;
    // Start is called before the first frame update
    void Start()
    {
        controlledRigidbody = GetComponent<Rigidbody2D>();
    }

    public void SetTarget(Vector3 target)
    {

        targetVelocity = target - transform.position;

        if (targetVelocity.magnitude > slowdownThreshold)
        {
            targetVelocity = targetVelocity.normalized * slowdownThreshold;
        }

        targetVelocity *= speed / slowdownThreshold;

        currentVelocity = Vector3.Lerp(currentVelocity, targetVelocity, acceleration * Time.deltaTime);

        controlledRigidbody.velocity = currentVelocity;

    }
}
