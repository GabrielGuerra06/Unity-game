using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{

    public RuntimeAnimatorController[] animl;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.GetComponent<Animator>().runtimeAnimatorController = animl[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            animator.GetComponent<Animator>().runtimeAnimatorController = animl[0];
        }

       

        if (Input.GetKeyUp(KeyCode.D))
        {
            animator.GetComponent<Animator>().runtimeAnimatorController = animl[0];
        }



    }
}
