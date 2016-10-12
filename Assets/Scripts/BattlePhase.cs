using UnityEngine;
using System.Collections;

public class BattlePhase : MonoBehaviour
{

    // Use this for initialization


    GameObject RedMonsterField;
    GameObject BlueMonsterField;
    Card player1;
    Card player2;


    void Update()
    {

        if (GameObject.FindGameObjectWithTag("Game").GetComponent<NewPhase>().currentPhase == NewPhase.Phases.AttackPhase)
        {


            RedMonsterField = GameObject.FindGameObjectWithTag("Red Monster Field");
            BlueMonsterField = GameObject.FindGameObjectWithTag("Blue Monster Field");

            player1 = RedMonsterField.GetComponentInChildren<CardControl>().getCardInfo();
            player2 = BlueMonsterField.GetComponentInChildren<CardControl>().getCardInfo();


            if (player1.getAttackPower() > player2.getAttackPower())
            {

                Destroy(BlueMonsterField.GetComponentInChildren<CardControl>().gameObject);

            }

            else if (player1.getAttackPower() < player2.getAttackPower())
            {

                Destroy(RedMonsterField.GetComponentInChildren<CardControl>().gameObject);

            }


            else if (player1.getAttackPower() == player2.getAttackPower())
            {
                Destroy(RedMonsterField.GetComponentInChildren<CardControl>().gameObject);
                Destroy(BlueMonsterField.GetComponentInChildren<CardControl>().gameObject);

            }

            
        }
    }





        


    public void getMonster()
        {
 
             

        }



    }


















     

        
    

