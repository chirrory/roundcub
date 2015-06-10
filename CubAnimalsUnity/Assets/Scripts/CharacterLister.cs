using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public static class CharacterLister 
{
    public static List<Character> Characters;

}

[Serializable]
public class Character
{
    public string Name;
    public GameObject Body;
    public bool Unlocked;

}
