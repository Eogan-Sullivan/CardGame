using UnityEngine;
using System.Collections;

public class blueHandReference : MonoBehaviour {
    public GameObject blueHand;
    public GameObject blueMonsterZone;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	
    }

    public void enableBlueHand()
    {
        blueHand.SetActive(true);
        blueMonsterZone.SetActive(true);
    }

    public void disableBlueHand()
    {
        blueHand.SetActive(false);
        blueMonsterZone.SetActive(false);
    }
}
