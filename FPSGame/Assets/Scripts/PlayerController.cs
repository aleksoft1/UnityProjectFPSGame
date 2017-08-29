using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed;
    public float rotationSpeed = 3;
    public float jump = 7;
    public GameObject mainCamera;

    private Rigidbody rb;
    private Vector3 velocityForward;
    private Vector3 velocityАwry;
    private bool isInAir = false;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            velocityForward = transform.forward * speed;
            velocityАwry = Vector3.zero;
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            velocityForward = -transform.forward * speed;
            velocityАwry = Vector3.zero;
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            velocityАwry = transform.right * speed;
            velocityForward = Vector3.zero;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            velocityАwry = -transform.right * speed;
            velocityForward = Vector3.zero;
        }
        else
        {
            velocityАwry = Vector3.zero;
            velocityForward = Vector3.zero;
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) && isInAir == false) {
            rb.velocity = new Vector3(0, jump, 0);
            isInAir = true;
        }
        
        rb.velocity = new Vector3(velocityАwry.x, rb.velocity.y, velocityForward.z);
        rb.rotation = Quaternion.Euler(rb.rotation.eulerAngles + new Vector3(0f, rotationSpeed * Input.GetAxis("Mouse X"), 0f));
        mainCamera.transform.rotation = Quaternion.Euler(mainCamera.transform.rotation.eulerAngles + new Vector3(-rotationSpeed * Input.GetAxis("Mouse Y"),0f, 0f));
        //Debug.Log(mainCamera.transform.rotation);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground") {
            isInAir = false;
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log(other);
    //}
}
