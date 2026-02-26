using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class CardDisplay : MonoBehaviour
{
    public Card2 card;

    public Text nameText;
    public Text descriptionText;

    public Text brainsText;
    public Text styleText;
    public Text evilText;
    public Text nimbleText;
    public Text stomachText;
    public Text comedyText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nameText.text = card.name;
        descriptionText.text = card.description;

        brainsText.text = card.brains.ToString();
        styleText.text = card.style.ToString();
        evilText.text = card.evil.ToString();
        nimbleText.text = card.nimble.ToString();
        stomachText.text = card.stomach.ToString();
        comedyText.text = card.comedy.ToString();

    }
}
