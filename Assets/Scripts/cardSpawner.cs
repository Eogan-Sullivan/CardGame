using UnityEngine;
using System.Collections;

public class cardSpawner : MonoBehaviour {


    

	// Use this for initialization
	void Start () {

        

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void spawnCard(GameObject card)
    {
        Instantiate(card, new Vector3(-3.0f, 0.25f, -3.0f), Quaternion.identity);
        
    }
}
