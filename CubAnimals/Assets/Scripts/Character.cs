using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

    Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        { 
            //Move right
            gameObject.transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * 1000);
        }
	}
}
