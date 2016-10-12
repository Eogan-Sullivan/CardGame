using UnityEngine;
using System.Collections;

public class redHandReference : MonoBehaviour {
    public GameObject redHand;
    public GameObject redMonsterZone;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void enableRedHand()
    {
        redHand.SetActive(true);
        redMonsterZone.SetActive(true);
    }

    public void disableRedHand()
    {
        redHand.SetActive(false);
        redMonsterZone.SetActive(false);
    }
}
