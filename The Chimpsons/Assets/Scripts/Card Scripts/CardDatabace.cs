using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabace : MonoBehaviour
{
    // creates a list for the new cards (like an array in JS)
    public static List<Card> cardList = new List<Card>();

    // the first 0 is the id of the card, the second component "" is the string/name, the third, fourth, fith, sixth, seventh and eighth components are
    // the Brains, Style, Evil, Nimble, Stomach and Comedy values and the ninth component is the card description
    void Awake()
    {
        cardList.Add(new Card(0, "Lisa Chimpson", 10, 2, 1, 4, 1, 3, "", "10", "2", "1", "4", "1", "3", "BAAAAAAAART", Resources.Load<Sprite>("Lisa Final") ));
        cardList.Add(new Card(1, "Marge Chimpson", 6, 5, 2, 3, 4, 4, "", "6", "5", "2", "3", "4", "4", "Hmmmmmmmm", Resources.Load<Sprite>("Lisa Final") ));
        cardList.Add(new Card(2, "Homer Chimpson", 1, 2, 1, 2, 10, 8, "", "1", "2", "1", "2", "10", "8", "D'oh!", Resources.Load<Sprite>("Lisa Final") ));
        cardList.Add(new Card(3, "Bart Chimpson", 4, 10, 3, 4, 1, 9, "", "4", "10", "3", "4", "1", "9", "¡Ay, caramba!", Resources.Load<Sprite>("Lisa Final") ));
        cardList.Add(new Card(4, "Maggy Chimpson", 9, 1, 3, 1, 1, 2, "", "9", "1", "3", "1", "1", "2", "*Suck Suck*", Resources.Load<Sprite>("Lisa Final") ));
        cardList.Add(new Card(5, "Banana Burns", 8, 1, 10, 1, 3, 5, "", "8", "1", "10", "1", "3", "5", "Exelent", Resources.Load<Sprite>("Lisa Final") ));
        cardList.Add(new Card(6, "Sidechimp Bob", 6, 2, 9, 5, 2, 6, "", "6", "2", "9", "5", "2", "6", "Hello, Bart", Resources.Load<Sprite>("Lisa Final") ));
        cardList.Add(new Card(7, "Chimp Flanders", 4, 8, 1, 7, 1, 5, "", "4", "8", "1", "7", "1", "5", "How diddlydoo nabour", Resources.Load<Sprite>("Lisa Final") ));
        cardList.Add(new Card(8, "Apu Chimp", 6, 3, 1, 2, 4, 5, "", "6", "3", "1", "2", "4", "5", "thank you, come again", Resources.Load<Sprite>("Lisa Final") ));
        cardList.Add(new Card(9, "Chimphouse van Hooten", 10, 2, 1, 3, 5, 3, "", "10", "2", "1", "3", "5", "3", "Everything's coming up Chimphouse!", Resources.Load<Sprite>("Lisa Final") ));
        cardList.Add(new Card(10, "Krusty the Chimp", 3, 8, 3, 4, 6, 8, "", "3", "8", "3", "4", "6", "8", "Hey, Hey Kids!", Resources.Load<Sprite>("Lisa Final") ));
        cardList.Add(new Card(11, "Moe Szychimp", 4, 3, 6, 2, 8, 7, "", "4", "3", "6", "2", "8", "7", "Ah, geez!!!", Resources.Load<Sprite>("Lisa Final") ));
        cardList.Add(new Card(12, "Barney Chimple", 1, 2, 1, 3, 10, 8, "", "1", "2", "1", "3", "10", "8", "I..I don't know nothin' 'bout anythin'", Resources.Load<Sprite>("Lisa Final") ));
        cardList.Add(new Card(13, "Nelson Chimp", 1, 3, 9, 4, 6, 7, "", "1", "3", "9", "4", "6", "7", "HA HA!", Resources.Load<Sprite>("Lisa Final") ));
        cardList.Add(new Card(14, "Edna Monkey", 6, 3, 5, 2, 3, 6, "", "6", "3", "5", "2", "3", "6", "HA!", Resources.Load<Sprite>("Lisa Final") ));
        cardList.Add(new Card(15, "Principal Chimper", 3, 2, 5, 2, 3, 7, "", "3", "2", "5", "2", "3", "7", "Your mine Chimpson boy", Resources.Load<Sprite>("Lisa Final") ));
        cardList.Add(new Card(16, "Chimplong Smithers", 5, 3, 3, 6, 2, 5, "", "5", "3", "3", "6", "2", "5", "Yes sir", Resources.Load<Sprite>("Lisa Final") ));
        cardList.Add(new Card(17, "Chimpskeeper Willie", 3, 5, 5, 7, 3, 9, "", "3", "5", "5", "7", "3", "9", "Then grease me up, woman!", Resources.Load<Sprite>("Lisa Final") ));
        cardList.Add(new Card(18, "Martin Chimp", 10, 2, 1, 3, 6, 3, "", "10", "2", "1", "3", "6", "3", "Behold!", Resources.Load<Sprite>("Lisa Final") ));
        cardList.Add(new Card(19, "Chimpy Leonard", 5, 3, 4, 5, 6, 4, "", "5", "3", "4", "5", "6", "4", "Hey Homer", Resources.Load<Sprite>("Lisa Final") ));
        cardList.Add(new Card(20, "Chimp Carlson", 4, 3, 4, 5, 7, 4, "", "4", "3", "4", "5", "7", "4", "Hey Homer", Resources.Load<Sprite>("Lisa Final") ));
        cardList.Add(new Card(21, "Dr. Chimpert", 5, 2, 1, 3, 6, 5, "", "5", "2", "1", "3", "6", "5", "do you suffer from diabetes?... Well you do now", Resources.Load<Sprite>("Lisa Final") ));
        cardList.Add(new Card(22, "Chimp Tony", 3, 3, 9, 3, 7, 5, "", "3", "3", "9", "3", "7", "5", "What's A Murder?", Resources.Load<Sprite>("Lisa Final") ));
        cardList.Add(new Card(23, "Chimp Wiggum", 1, 6, 4, 1, 8, 5, "", "1", "6", "4", "1", "8", "5", "Cuff 'em, Lou", Resources.Load<Sprite>("Lisa Final") ));
        cardList.Add(new Card(24, "Granpa Chimpson", 1, 5, 2, 1, 4, 8, "", "1", "5", "2", "1", "4", "8", "I Used To Be With It, But Then They Changed What 'It' Was", Resources.Load<Sprite>("Lisa Final") ));
        cardList.Add(new Card(25, "Chimplady Doris", 2, 3, 6, 4, 3, 6, "", "2", "3", "6", "4", "3", "6", "Whatever", Resources.Load<Sprite>("Lisa Final") ));
        cardList.Add(new Card(26, "Agnes Chimper", 6, 3, 5, 1, 1, 4, "", "6", "3", "5", "1", "1", "4", "Seymour! The house is on fire!!", Resources.Load<Sprite>("Lisa Final") ));
        cardList.Add(new Card(27, "Chimp Moyai", 0, 0, 0, 0, 0, 10, "", "0", "0", "0", "0", "0", "10", "................", Resources.Load<Sprite>("Lisa Final") ));

    }

    // cardList.Add(new Card(0, "", 0, 0, 0, 0, 0, 0, ""));

}
