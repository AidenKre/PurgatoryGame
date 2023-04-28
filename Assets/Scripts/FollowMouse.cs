using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public GameObject obj;
    public float delay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse_pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse_pos += new Vector3(0, 0, 10);
        float x_translate = delay * (-1 * obj.transform.position.x + mouse_pos.x);
        float y_translate = delay * (-1 * obj.transform.position.y + mouse_pos.y);
        obj.transform.position += new Vector3(x_translate, y_translate);
        
        
    }
}
