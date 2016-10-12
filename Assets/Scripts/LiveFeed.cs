using UnityEngine;
using System.Collections;

public class LiveFeed : MonoBehaviour
{

    // Use this for initialization


    public Camera player1Soldier;
    public Camera player2Soldier;
    public Camera overView;
    void Start()
    {

        player1Soldier.enabled = false;
        player2Soldier.enabled = false;
        overView.enabled = true;


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("a"))
        {
            player1Soldier.enabled = false;
            player2Soldier.enabled = true;
            overView.enabled = false;
        }


        if (Input.GetKeyDown("s"))
        {
            player1Soldier.enabled = false;
            player2Soldier.enabled = false;
            overView.enabled = true;
        }

        if (Input.GetKeyDown("d"))
        {
            player1Soldier.enabled = true;
            player2Soldier.enabled = false;
            overView.enabled = false;
        }
    }


}