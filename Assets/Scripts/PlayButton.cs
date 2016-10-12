using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour
{

    // Use this for initialization

    public void ChangeScene(int thisScene)
    {
        Application.LoadLevel(thisScene);
    }

   
}