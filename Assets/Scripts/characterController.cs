using UnityEngine;
using System.Collections;

public class characterController : MonoBehaviour {
     Animator animator;
	// Use this for initialization
	void Start () {
        animator.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W))
            animator.SetBool("toWalk", true);
        
        if (Input.GetKey("E"))
            animator.SetBool("toRun", true);
            
    }
}    

