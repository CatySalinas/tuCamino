using System.Collections.Generic;
using UnityEngine;



public class TrunkAnimator : MonoBehaviour
{

    Animator animator;

    public void Press()
    {
        string ComponentName = GetComponent<Component>().name;
        if (animator == null){
            animator = GetComponent<Animator>();
        }

        Debug.Log("Pressing Button " + ComponentName);

        animator.GetComponent<Animator>();
        animator.SetTrigger("Pressed");

    }
}
