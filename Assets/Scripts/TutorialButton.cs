using UnityEngine;
using System.Collections;

public class TutorialButton : MonoBehaviour {

	// Use this for initialization

    public void ChangeScene(int thisScene)
    {

        Application.LoadLevel(thisScene);

    }


}
