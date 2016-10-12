using UnityEngine;
using System.Collections;

public class monsterSpawner : MonoBehaviour {

    public GameObject seaMan;
    public GameObject airMan;
    public GameObject landMan;
    public GameObject turret;
    public GameObject battleShip;
    public GameObject plane;

    public float nextAvailableSpace;


    bool redSpaceOneFree = true, redSpaceTwoFree = true, redSpaceThreeFree = true, redSpaceFourFree = true;
    bool blueSpaceOneFree = true, blueSpaceTwoFree = true, blueSpaceThreeFree = true, blueSpaceFourFree = true;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void spawnSeaMan()
    {
        Debug.Log("Found Sea Man");
        nextAvailableSpace = checkNextSpawn();

        if (GameObject.FindGameObjectWithTag("Game").GetComponent<NewPhase>().currentPhase == NewPhase.Phases.blueMainPhase)
        {
            Instantiate(seaMan, new Vector3(-81.42f, 165.9219f, nextAvailableSpace), Quaternion.Euler(0.0f, 90.0f, 0.0f));
        }

        else
            Instantiate(seaMan, new Vector3(-77.3f, 165.9219f, nextAvailableSpace), Quaternion.Euler(0.0f, -90.0f, 0.0f));
    }

    public void spawnAirMan()
    {
        Debug.Log("Found Air Man");
        nextAvailableSpace = checkNextSpawn();

        if (GameObject.FindGameObjectWithTag("Game").GetComponent<NewPhase>().currentPhase == NewPhase.Phases.blueMainPhase)
        {
            Instantiate(airMan, new Vector3(-81.42f, 165.9219f, nextAvailableSpace), Quaternion.Euler(0.0f, 90.0f, 0.0f));
        }

        else
            Instantiate(airMan, new Vector3(-77.3f, 165.9219f, nextAvailableSpace), Quaternion.Euler(0.0f, -90.0f, 0.0f));
    }

    public void spawnLandMan()
    {
        Debug.Log("Found Land Man");
        nextAvailableSpace = checkNextSpawn();

        if (GameObject.FindGameObjectWithTag("Game").GetComponent<NewPhase>().currentPhase == NewPhase.Phases.blueMainPhase)
        {
            Instantiate(landMan, new Vector3(-81.42f, 166.9219f, nextAvailableSpace), Quaternion.Euler(0.0f, 90.0f, 0.0f));
        }

        else
            Instantiate(landMan, new Vector3(-77.3f, 166.9219f, nextAvailableSpace), Quaternion.Euler(0.0f, -90.0f, 0.0f));
    }

    public void spawnTurret()
    {
        Debug.Log("Found Sea Man");
        nextAvailableSpace = checkNextSpawn();

        if (GameObject.FindGameObjectWithTag("Game").GetComponent<NewPhase>().currentPhase == NewPhase.Phases.blueMainPhase)
        {
            Instantiate(turret, new Vector3(-81.42f, 164.9219f, nextAvailableSpace), Quaternion.Euler(0.0f, 90.0f, 0.0f));
        }

        else
            Instantiate(turret, new Vector3(-77.3f, 164.9219f, nextAvailableSpace), Quaternion.Euler(0.0f, -90.0f, 0.0f));
    }

    public void spawnBattleShip()
    {
        Debug.Log("Found Battleship");
        nextAvailableSpace = checkNextSpawn();

        if (GameObject.FindGameObjectWithTag("Game").GetComponent<NewPhase>().currentPhase == NewPhase.Phases.blueMainPhase)
        {
            Instantiate(battleShip, new Vector3(-81.42f, 165.9219f, nextAvailableSpace), Quaternion.Euler(0.0f, 90.0f, 0.0f));
        }

        else
            Instantiate(battleShip, new Vector3(-77.3f, 165.9219f, nextAvailableSpace), Quaternion.Euler(0.0f, -90.0f, 0.0f));
    }

    public void spawnPlane()
    {
        Debug.Log("Found Plane");
        nextAvailableSpace = checkNextSpawn();

        if (GameObject.FindGameObjectWithTag("Game").GetComponent<NewPhase>().currentPhase == NewPhase.Phases.blueMainPhase)
        {
            Instantiate(plane, new Vector3(-81.42f, 166.9219f, nextAvailableSpace), Quaternion.Euler(0.0f, -90.0f, 0.0f));
        }

        else
            Instantiate(plane, new Vector3(-77.3f, 166.9219f, nextAvailableSpace), Quaternion.Euler(0.0f, 90.0f, 0.0f));
    }


    public float checkNextSpawn()
    {
        if (GameObject.FindGameObjectWithTag("Game").GetComponent<NewPhase>().currentPhase == NewPhase.Phases.blueMainPhase) {
            if (blueSpaceOneFree == true)
            {
                blueSpaceOneFree = false;
                return -3.22f;
            }

            else if (blueSpaceTwoFree == true)
            {
                blueSpaceTwoFree = false;
                return -1.55f;
            }

            else if(blueSpaceThreeFree == true)
            {
                blueSpaceThreeFree = false;
                return 0.29f;
            }

            else
            {
                blueSpaceFourFree = false;
                return 2.25f;
            }
            
        }

        else
        {
            if (redSpaceOneFree == true)
            {
                redSpaceOneFree = false;
                return -3.25f;
            }

            else if (redSpaceTwoFree == true)
            {
                redSpaceTwoFree = false;
                return -1.52f;
            }

            else if (redSpaceThreeFree == true)
            {
                redSpaceThreeFree = false;
                return 0.21f;
            }

            else
            {
                redSpaceFourFree = false;
                return 2.11f;
            }

        }
    }
}
