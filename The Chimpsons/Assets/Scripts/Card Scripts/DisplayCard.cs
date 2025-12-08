using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DisplayCard : MonoBehaviour
{
    // takes a card from the list and displayes it with the corresponding values asigned to it
    public List<Card> displayCard = new List<Card>();
    public int displayId;

    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDescription;

    public Text nameText;
    public Text descriptionText;

    // when we start up the game, it will display a card
    void Start()
    {
        displayCard[0] = CardDatabace.cardList[displayId];
    }

    // makes sure all values are up to date every frame
    void Update()
    {
        id = displayCard[0].id;
        cardName = displayCard[0].cardName;
        cardDescription = displayCard[0].cardDescription;

        nameText.text = " " + cardName;
        descriptionText.text = " " + cardDescription;
    }

}
