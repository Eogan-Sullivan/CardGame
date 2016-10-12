using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class CardControl : MonoBehaviour {

    string Title;
    Text instruction;
    Card mycard;
    sqlTester myScript;
    GameObject deckManager;

	// Use this for initialization
	void Start () {

        
        
        deckManager = GameObject.FindGameObjectWithTag("DeckManager");
        myScript = deckManager.GetComponent<sqlTester>();
        Title = getCardName();
        instruction = GetComponent<Text>();
        instruction.text = Title;
    
	}

    void update()
    {
        Title = getCardName();
    }

    public String getCardName()
    {
        mycard = myScript.pullCard();
       String name = mycard.getCardTitle() + "\n" + mycard.getAttribute() + "Attack:" + mycard.getAttackPower() + "\n Health" + mycard.getHealth(); 
       return name;
    }

    public Card getCardInfo()
    {
        Debug.Log("In card Info");


        return mycard;
    }


}
