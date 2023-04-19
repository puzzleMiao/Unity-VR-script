using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;


public class HideReveal_UI : MonoBehaviour
{
    public Canvas Canvas01;
    // Start is called before the first frame update
    public void HoverOver()
    {
        Canvas01.enabled = !Canvas01.enabled;
       
    }

    // Update is called once per frame
    public void HoverEnd()
    {
        Canvas01.enabled = !Canvas01.enabled;
    }
}
