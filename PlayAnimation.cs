using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{

    [SerializeField] private Animator myAnimationController;
    // Start is called before the first frame update
    public void HoverOver()
    {

        myAnimationController.SetBool("PlayAnimation", true);


    }

    // Update is called once per frame
    public void HoverEnd()
    {

        myAnimationController.SetBool("PlayAnimation", false);
    }
}
