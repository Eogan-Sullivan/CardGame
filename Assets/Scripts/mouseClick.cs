using UnityEngine;
using System.Collections;

public class mouseClick : MonoBehaviour {
    public Vector3 mouseLocation;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            mouseLocation = getMousePosition();
        }
	}

    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clicked!");
                    
        }
    }

    public void OnGUI()
    {
        GUI.Button(new Rect(mouseLocation.x, mouseLocation.y, 100, 50), "Attack");
    }

    public Vector3 getMousePosition()
    {
        return Input.mousePosition;
    }
}
