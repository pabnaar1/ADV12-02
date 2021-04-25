using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutantScript : MonoBehaviour
{
    public float Downancell = 1f;  
    private Animator animator;
    private CharacterController charController;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        charController.Move(Vector3.down * Downancell * Time.deltaTime);
        animator.SetFloat("Vertical", 0);
        animator.SetFloat("Horizontal", 0);

        if (Input.GetKey(KeyCode.I))
        {
            animator.SetFloat("Vertical", 1);
        }

        if (Input.GetKey(KeyCode.K))
        {
            animator.SetFloat("Vertical", -1);
        }

        if (Input.GetKey(KeyCode.J))
        {
            animator.SetFloat("Horizontal", -1);
        }

        if (Input.GetKey(KeyCode.L))
        {
            animator.SetFloat("Horizontal", 1);
        }

    }
}
