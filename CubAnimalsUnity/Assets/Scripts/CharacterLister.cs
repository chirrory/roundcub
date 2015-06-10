using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class CharacterLister : MonoBehaviour
{
    public List<Character> Characters;
}

[Serializable]
public class Character
{
    public string Name;
    public GameObject Body;
    public int test;
}
