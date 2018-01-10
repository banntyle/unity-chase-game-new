using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayanimationonkeydown : MonoBehaviour 
{
    public KeyCode key;
    public string triggerName;
    public Animator animator;

    void update()
    {
        if (Input.GetKeyDown(key))
        {
            animator.SetTrigger(triggerName);
        }

    }
}