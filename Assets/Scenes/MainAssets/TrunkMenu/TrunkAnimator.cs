using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class TrunkAnimator : MonoBehaviour
{

    Animator animator;

    public void Press()
    {
        //Gets the Component animator
        animator = GetComponent<Animator>();
        animator.GetComponent<Animator>();

        //Sets a trigger in animator to play animation.
        animator.SetTrigger("Pressed");

    }
}
