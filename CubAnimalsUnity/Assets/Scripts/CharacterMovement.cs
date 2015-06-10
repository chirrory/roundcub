using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

    Rigidbody2D rb;
    bool jumping;
	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody2D>();
	}

    //TODO: Sensible input system
    //TODO: Swapping character
    //TODO: Instantiating the character at the beginning of the level
    //TODO: Character interacts w/ stuff
    //TODO: Character has lifes 
    //TODO: Character can die
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            //Move right
            gameObject.transform.Translate(new Vector3(2, 0, 0) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(new Vector3(-2, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space) && !jumping)
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
