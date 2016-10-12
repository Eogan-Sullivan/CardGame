﻿using UnityEngine;
using System.Collections;

public class Card  {

    private string cardTitle;
    private int cardId;
    private int health;
    private int attackPower; 
    private string description;
    private string  attribute;
    private int manaCost;


   public Card()
    {
        cardId = 0;
        cardTitle = "Unknown";
        health = 100;
        attackPower = 100;
        description = "unknown";
        attribute = "Unknown";
        manaCost = 0;
    }


    public Card(int cardId,string cardTitle,int health,int attackPower,string description,string attribute, int manaCost)
    {
        setCardId(cardId);
        setCardTitle(cardTitle);
        setHealth(health);
        setAttackPower(attackPower);
        setDescription(description);
        setAttribute(attribute);
        setManaCost(manaCost);
    }

    public string getAttribute()
    {
        return attribute;
    }


    public string getDescription()
    {
        return description;
    }

    public int getAttackPower()
    {
        return attackPower;

    }

    public int getHealth()
    {
        return health;
    }

    public int getCardId()
    {
        return cardId;

    }


     public string CardTitle
        {
        get
        {
            return cardTitle;
        }
        set
        {

            cardTitle = value;
        }

        }
    public string getCardTitle()
    {
        return cardTitle;
    }

    //mutators
    public void setCardTitle(string cardTitle)
    {
        this.cardTitle = cardTitle;
    }

    public void setCardId(int cardId)
    {
        this.cardId = cardId;
    }

    public void setHealth(int health)
    {
        this.health = health;
    }

    public void setAttackPower(int attackPower)
    {
        this.attackPower = attackPower;
    }

    public void setDescription(string description)
    {
        this.description = description;
    }

    public void setAttribute(string attribute)
    {
        this.attribute = attribute;
    }

    public void setManaCost(int manaCost)
    {
        this.manaCost = manaCost;
    }

    public string toString()
    {
        return "Card Name: " + getCardTitle() + "Card Power: " + getAttackPower();
    }

}
