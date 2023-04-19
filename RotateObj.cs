using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObj : MonoBehaviour
{
    
    public float rotateSpeed = 180f;
    public GameObject Object;
    bool rotate = false;


    private void FixedUpdate()
    {
        if (rotate == false)
            return;
        Object.transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
    }
    // Start is called before the first frame update
    public void HoverOver()
    {

        rotate = true;


    }

    // Update is called once per frame
    public void HoverEnd()
    {

        rotate = false;
        //Object.transform.Rotate(Time.deltaTime * speed, 0, 0, Space.Self);
        //Object.transform.Rotate(Vector3.forward * speed2 * Time.deltaTime);
    }
}
