using UnityEngine;
using System.Collections;

public class MovePlatform : MonoBehaviour {
    Vector2 startPosition;
    Vector2 currentPosition;
    public float moveRange = 5;
    public Transform platform;
    Vector3 leftMax;
    Vector3 rightMax;
    public bool moveRight = false;
	void Start () {
       startPosition = platform.transform.position;
       rightMax = new Vector2(startPosition.x+moveRange, startPosition.y);
       leftMax = new Vector2(startPosition.x-moveRange, startPosition.y);
    }

	void Update (){
        if (MoveRight(gameObject.transform.position))
        {
            gameObject.transform.Translate((new Vector3(5, 0, 0) * Time.deltaTime));
        }
        else
        {
            gameObject.transform.Translate((new Vector3(-5, 0, 0) * Time.deltaTime));
        }
	}

    bool MoveRight(Vector3 pos)
    {

        if (pos.x >= rightMax.x)
        {
            moveRight = false;
        }
        else if (pos.x <= leftMax.x)
        {
            moveRight = true;
        }
        return moveRight;
    }
}
