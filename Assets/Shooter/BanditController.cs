using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditController : MonoBehaviour {

    private bool grounded = false;

    public float speed = 1;

	// Use this for initialization
	void Start () {

    }

    // Update is called once per frame
    void Update () {
		
	}

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision");
        if (collision.collider.tag == "Ground")
        {
            grounded = true;

            //GetComponent<Rigidbody>().AddForce(new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Horizontal")));
            GetComponent<Rigidbody>().AddForce(transform.forward * speed);
        }
    }
}
