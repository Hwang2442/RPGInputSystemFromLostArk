using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystemFromLostArk : MonoBehaviour
{
    public Animator animator;

    private void Start()
    {
        animator ??= FindObjectOfType<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SetAnimatorTrigger(KeyCode.Q);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            SetAnimatorTrigger(KeyCode.W);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            SetAnimatorTrigger(KeyCode.E);
        }
    }

    private void SetAnimatorTrigger(KeyCode keyCode)
    {
        animator.SetTrigger(string.Format("Attack_{0}", keyCode.ToString()));
    }
}
