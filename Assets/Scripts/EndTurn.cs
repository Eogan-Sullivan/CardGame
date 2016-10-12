using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndTurn : MonoBehaviour {

    public bool redTurn;
    public bool blueTurn;

	// Use this for initialization
	void Start () {
        redTurn = true;
        blueTurn = false;

        
	}
	
	// Update is called once per frame
	void Update () {

        if(redTurn == true)
        {
            Camera.main.transform.position = new Vector3(0.0f, 5.5f, -8.5f);
            Camera.main.transform.rotation = Quaternion.Euler(45, 0, 0);

            
        }

        else
        {
            Camera.main.transform.position = new Vector3(0.0f, 5.5f, 8.5f);
            Camera.main.transform.rotation = Quaternion.Euler(45, 180, 0);
        }
	}

    public void endTurn()
    {
        if (redTurn == true)
        {
            redTurn = false;
            blueTurn = true;
        }

        else
        {
            redTurn = true;
            blueTurn = false;
        }
    }

    
}
