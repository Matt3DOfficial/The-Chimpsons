using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckPanelCard : MonoBehaviour
{
    public GameObject cardBack;

     
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cardBack.SetActive(true);
    }
}
