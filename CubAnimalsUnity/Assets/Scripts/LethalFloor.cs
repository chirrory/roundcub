using UnityEngine;
using System.Collections;

public class LethalFloor : MonoBehaviour {

    void OnCollisionEnter2D()
    {
        Application.LoadLevel(Application.loadedLevelName);
    }
}
