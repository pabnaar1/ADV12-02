using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Collider))]

public class script : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public string parametroBoolean;
    bool b = false;
    private void OnTriggerEnter(Collider Other)
    {
        b = !b;
        animator.SetBool(parametroBoolean, b);
    }
}
