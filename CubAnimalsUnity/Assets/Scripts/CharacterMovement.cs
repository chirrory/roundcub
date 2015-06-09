using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

    Rigidbody2D rb;
    bool jumping;
	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody2D>();
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
        else if (Input.GetKeyDown(KeyCode.Space) && !jumping)
        {
            rb.AddForce(new Vector2(0,1) * 10, ForceMode2D.Impulse);
            jumping = true;
        }
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody>() == null)
        {
            jumping = false;
        }
    }
}
