using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwing : MonoBehaviour
{
    private Animator animator;
    private bool leftClick;
    private int hits;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            leftClick = true;
        }
        else
        {
            leftClick = false;
        }
    }
    private void FixedUpdate()
    {
        if (leftClick == true)
        {
            animator.SetBool("leftClick", true);
        }
        if (leftClick == false)
        {
            animator.SetBool("leftClick", false);
        }
    }
}
