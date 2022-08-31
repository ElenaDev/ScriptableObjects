using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Card", menuName ="Card")]
public class Card : ScriptableObject
{
    public Sprite spriteCard;
    public string nameCard;
    public int attack;
    public int health;
    public int mana;
   

    public void ShowName()
    {
        Debug.Log("Name Card: " + nameCard);
    }
}
