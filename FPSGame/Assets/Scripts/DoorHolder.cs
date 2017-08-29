using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHolder : MonoBehaviour {
    private Animator animator = null;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKey(KeyCode.Mouse1))
        {
            animator.SetBool("isOpen", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("isOpen", false);
    }
}
