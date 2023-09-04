using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Parameter : MonoBehaviour
{
    public Animator Cube_Animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            Cube_Animator.SetBool("Up", true);
        }
    }
}
