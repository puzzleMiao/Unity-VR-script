using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Material : MonoBehaviour
{
    public Material material1;
    public Material material2;

    // Start is called before the first frame update
    public void HoverOver()
    {
        GetComponent<Renderer>().material = material2;
    }

    // Update is called once per frame
    public void HoverEnd()
    {
        GetComponent<Renderer>().material = material1;
    }
}
