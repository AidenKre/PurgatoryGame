using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public Vector3 speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speed);
    }
}
