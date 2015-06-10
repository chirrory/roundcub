using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

    Rigidbody2D rb;
    bool jumping;
	// Use this for initialization

	void Start () 
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
	}

    //TODO: Sensible input system
    //TODO: Swapping character, only when the player does so in a menu

    //TODO: Instantiating the character at the beginning of the level
    //TODO: Character interacts w/ stuff
    //TODO: Character has lifes 
    //TODO: Character can die
	
	void Update () {

        float xAxis = Input.GetAxis("Horizontal");
        if (xAxis > 0)
        {
            //Move right
            gameObject.transform.Translate(new Vector3(5, 0, 0) * Time.deltaTime);
        }

        else if (xAxis < 0)
        {
            gameObject.transform.Translate(new Vector3(-5, 0, 0) * Time.deltaTime);
        }

        if (Input.GetButton("Jump") && !jumping)
        {
            rb.AddForce(new Vector2(0, 1) * 10, ForceMode2D.Impulse);
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
