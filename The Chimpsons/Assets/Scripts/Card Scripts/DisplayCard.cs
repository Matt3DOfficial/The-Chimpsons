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
    public int brains;
    public int style;
    public int evil;
    public int nimble;
    public int stomach;
    public int comedy;
    public string cardDescription;
    public string brainsDescription;
    public string styleDescription;
    public string evilDescription;
    public string nimbleDescription;
    public string stomachDescription;
    public string comedyDescription;
    public string voiceline;
    public Sprite spriteImage;

    public Text nameText;
    public Text descriptionText;
    public Text brainsText;
    public Text styleText;
    public Text evilText;
    public Text nimbleText;
    public Text stomachText;
    public Text comedyText;
    public Image artImage;

    public bool cardBack;
    public static bool staticCardBack;

    public GameObject Hand;
    public int numberOfCardsInDeck;


    // when we start up the game, it will display a card
    void Start()
    {
        numberOfCardsInDeck = PlayerDeck.deckSize;

        displayCard[0] = CardDatabace.cardList[displayId];
    }

    // makes sure all values are up to date every frame
    void Update()
    {

                id = displayCard[0].id;
        cardName = displayCard[0].cardName;
        cardDescription = displayCard[0].cardDescription;
        brainsDescription = displayCard[0].brainsDescription;
        styleDescription = displayCard[0].styleDescription;
        evilDescription = displayCard[0].evilDescription;
        nimbleDescription = displayCard[0].nimbleDescription;
        stomachDescription = displayCard[0].stomachDescription;
        comedyDescription = displayCard[0].comedyDescription;
        spriteImage = displayCard[0].spriteImage;

        nameText.text = " " + cardName;
        descriptionText.text = " " + cardDescription;
        brainsText.text = brainsDescription;
        styleText.text = styleDescription;
        evilText.text = evilDescription;
        nimbleText.text = nimbleDescription;
        stomachText.text = stomachDescription;
        comedyText.text = comedyDescription;
        artImage.sprite = spriteImage;

        Hand = GameObject.Find("Hand");
        if (this.transform.parent == Hand.transform.parent)
        {
            cardBack = false;
        }

        staticCardBack = cardBack;

        if (this.tag == "Clone")
        {
            displayCard[0] = PlayerDeck.staticDeck[numberOfCardsInDeck - 1];
            numberOfCardsInDeck -= 1;
            PlayerDeck.deckSize -= 1;
            cardBack = false;
            this.tag = "untagged";


        }
    }

}
