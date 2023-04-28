using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{

    Movement movement;

    [SerializeField] float centerDeadzone = 1;
    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        Vector3 cameraCenter = getCameraCenter();
        float distanceToCenter = (mousePos - cameraCenter).magnitude;

        if (distanceToCenter < centerDeadzone)
        {
            movement.SetTarget(cameraCenter);
        }
        else
        {
            movement.SetTarget(mousePos);
        }

    }

    Vector3 getCameraCenter()
    {
        Vector3 center = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f));
        center.z = 0;
        return center;
    }
}
