using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMoveController : MonoBehaviour
{
    Movement movement;
    [SerializeField] GameObject targetObject;
    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {


        movement.SetTarget(targetObject.transform.position);
    }
}
