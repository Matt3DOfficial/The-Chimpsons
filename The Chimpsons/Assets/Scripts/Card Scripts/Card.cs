using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card
{
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
    // public image variable;

    public Card()
    {

    }

    // enusres that these variables are public and links the name of "Card" to the attacked int's and strings
    public Card (int Id, string CardName, int Brains, int Style, int Evil, int Nimble, int Stomach, int Comedy, string CardDescription, string BrainsDescription, 
        string StyleDescription, string EvilDescription, string NimbleDescription, string StomachDescription, string ComedyDescription, string Voiceline, Sprite SpriteImage)
    {
        id = Id;
        cardName = CardName;
        brains = Brains;
        style = Style;
        evil = Evil;
        nimble = Nimble;
        stomach = Stomach;
        comedy = Comedy;
        cardDescription = CardDescription;
        brainsDescription = BrainsDescription;
        styleDescription = StyleDescription;
        evilDescription = EvilDescription;
        nimbleDescription = NimbleDescription;
        stomachDescription = StomachDescription;
        comedyDescription = ComedyDescription;
        voiceline = Voiceline;
        spriteImage = SpriteImage;
    }
}
