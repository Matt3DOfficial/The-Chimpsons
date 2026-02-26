using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card2 : ScriptableObject
{

    public string cardName;
    public string description;
    public int brains;
    public int style;
    public int evil;
    public int nimble;
    public int stomach;
    public int comedy;

    public void Print()
    {
        Debug.Log(cardName + ": " + description + " The card costs: ");
    }

}
