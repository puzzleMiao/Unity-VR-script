using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_GameObject : MonoBehaviour
{
    public GameObject gameObj1;
    public GameObject gameObj2;

    // Start is called before the first frame update
    public void HoverOver()
    {
        gameObj1.GetComponent<MeshRenderer>().enabled = false;
        gameObj2.GetComponent<MeshRenderer>().enabled = true;
    }

    // Update is called once per frame
    public void HoverEnd()
    {
        gameObj1.GetComponent<MeshRenderer>().enabled = true;
        gameObj2.GetComponent<MeshRenderer>().enabled = false;
    }
}
