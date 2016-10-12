using UnityEngine;
using UnityEngine.UI;
using Mono.Data.Sqlite;
using System.Data;
using System;
using System.Collections;
using System.Collections.Generic;


public class sqlTester : MonoBehaviour {
    private String conn, phase;
	public int k = 0;
    public List<Card> deck;
    public List<Card> player1Hand;
    public List<Card> player2Hand;
    public GameObject cardPrefab;
    public GameObject cardInfo;

    public GameObject Hand;

    public String cardTitle;
    //Card cardPulled;
    // Use this for initialization

    void Start() {
   
        //Find the DB file in the assets folder 
        conn = "URI=file:" + Application.dataPath + "/CardDatabase.db";
        player1Hand = new List<Card>();
        player2Hand = new List<Card>();
        //at the start of the game the deck is created 
        deck = new List<Card>();
        for (int i = 0; i <= 40; i++)
             {
                 createDeck(i);
             }//end for

        //at the start of the game 5 cards are pulled from  the deck and added to player 1's hand. the same is also done for player 2

 for (int i = 0; i<5; i++)
        {
                Card cardPulled = pullCard();
                
                
                createRedCard(cardPulled);
                player1Hand.Add(cardPulled);
                
                
                Debug.Log("Gone through loop" + i + cardPulled.getCardTitle());

            cardTitle = cardPulled.getCardTitle();
            }

 for (int j = 0; j < 5; j++)
 {
     Card cardPulled = pullCard();


     createBlueCard(cardPulled);
     player2Hand.Add(cardPulled);


     Debug.Log("Gone through loop" + j + cardPulled.getCardTitle());

     cardTitle = cardPulled.getCardTitle();
 }

    }//end method

    // Update is called once per frame
    void Update()
    {



    }

    public Card pullCard()
    { 
  
        //Get information of Card from Database
            int  rnd = Convert.ToInt32(UnityEngine.Random.Range(0f, deck.Count));
            
            Card cardPulled = deck[rnd];
            deck.Remove(cardPulled);
            return cardPulled;       
    }

    public void createRedCard(Card cardinfo)
    {

        Hand = GameObject.FindGameObjectWithTag("RedHand");
        //print(Hand);

        
        GameObject cardPrefabInstance1 = (GameObject)Instantiate(cardPrefab, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
        cardPrefabInstance1.transform.SetParent(Hand.transform.parent);
        cardPrefab.name = cardinfo.getCardTitle();
        cardPrefabInstance1.transform.parent = Hand.transform;
        
    }

    public void createBlueCard(Card cardinfo)
    {

        Hand = GameObject.FindGameObjectWithTag("BlueHand");
        //print(Hand);

        //cardPrefab.transform.parent = Hand.transform.parent;
        GameObject cardPrefabInstance1 = (GameObject)Instantiate(cardPrefab, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
        cardPrefabInstance1.transform.SetParent(Hand.transform.parent);
        cardPrefab.name = cardinfo.getCardTitle();
        cardPrefabInstance1.transform.parent = Hand.transform;

    }

    private void createDeck(int i)
    {
        //creates a connection and opens
        using (IDbConnection dbConn = new SqliteConnection(conn))
        {
            dbConn.Open();
            //creates the command and the sql needed
            using (IDbCommand dbCmd = dbConn.CreateCommand())
            {
                string sqlQuery = "SELECT * FROM Cards where cardID = "+ i +";";
                
                dbCmd.CommandText = sqlQuery;
                //creates the reader and fills up a List with cards for the deck
                using (IDataReader reader = dbCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Card card = new Card();
                        card.setCardId(reader.GetInt32(0));
                        card.setCardTitle(reader.GetString(1));
                        card.setHealth(reader.GetInt32(2));
                        card.setAttackPower(reader.GetInt32(3));
                        card.setDescription(reader.GetString(4));
                        card.setAttribute(reader.GetString(5));
                        card.setManaCost(reader.GetInt32(6));
                        deck.Add(card);
                   

                    }//end while
                    //close the connection and the reader
                    dbConn.Close();
                    reader.Close();
                }//end using

            }//end using
        }//end using
    }//end method


    
}//end script
