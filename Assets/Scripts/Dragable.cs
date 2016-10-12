using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class Dragable : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler {
    public Transform snapBackParent = null;
    public Transform placeholderParent = null;
    public GameObject thisCard;

    public bool cardDraw = false;
 

    GameObject placeholder = null;

	public void OnBeginDrag( PointerEventData eventData){
        Debug.Log("OnBeginDrag");

        placeholder = new GameObject();
        placeholder.transform.SetParent(this.transform.parent);
        LayoutElement le = placeholder.AddComponent<LayoutElement>();
        le.preferredWidth = this.GetComponent<LayoutElement>().preferredWidth;
        le.preferredHeight = this.GetComponent<LayoutElement>().preferredHeight;
        le.flexibleWidth = 0;
        le.flexibleHeight = 0;

        placeholder.transform.SetSiblingIndex(this.transform.GetSiblingIndex());

        snapBackParent = this.transform.parent;
        placeholderParent = snapBackParent;
        this.transform.SetParent(this.transform.parent.parent);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    internal void DroppedinMonsterZone()
    {
        CardControl cardScript = transform.GetComponentInChildren<CardControl>();
        if (cardScript) print("Found");
        Card test2 = cardScript.getCardInfo();
        print(test2.CardTitle);
       string test =cardScript. getCardInfo().getCardId().ToString();
        Debug.Log("Dropped " + test);

        if (test2.getCardTitle().Equals("Sea Man"))
        {

            GameObject.FindGameObjectWithTag("Game").GetComponent<monsterSpawner>().spawnSeaMan();

        }

        else if (test2.getCardTitle().Equals("Air Man"))
        {

            GameObject.FindGameObjectWithTag("Game").GetComponent<monsterSpawner>().spawnAirMan();
        }

        else if (test2.getCardTitle().Equals("Land Man"))
        {
            
            GameObject.FindGameObjectWithTag("Game").GetComponent<monsterSpawner>().spawnLandMan();
        }

        else if (test2.getCardTitle().Equals("Master Blaster"))
        {

            GameObject.FindGameObjectWithTag("Game").GetComponent<monsterSpawner>().spawnTurret();
        }

        else if (test2.getCardTitle().Equals("Power Plane") || test2.getCardTitle().Equals("Super Spit Fire"))
        {

            GameObject.FindGameObjectWithTag("Game").GetComponent<monsterSpawner>().spawnPlane();
        }

        else if (test2.getCardTitle().Equals("SS Rubber Ducky"))
        {

            GameObject.FindGameObjectWithTag("Game").GetComponent<monsterSpawner>().spawnBattleShip();
        }

        else
        {
            Debug.Log("Error");
        }
    }

    public void OnDrag(PointerEventData eventData){
        
            Debug.Log("OnDrag");
            this.transform.position = eventData.position;

            if (placeholder.transform.parent != placeholderParent)
                placeholder.transform.SetParent(placeholderParent);

            int newSiblingIndex = placeholderParent.childCount;

            for (int i = 0; i < placeholderParent.childCount; i++)
            {
                if (this.transform.position.x < placeholderParent.GetChild(i).position.x)
                {

                    newSiblingIndex = i;

                    if (placeholder.transform.GetSiblingIndex() < newSiblingIndex)
                        newSiblingIndex--;

                    break;
                }
            }

            placeholder.transform.SetSiblingIndex(newSiblingIndex);
        
    }

    public void OnEndDrag(PointerEventData eventData){
        
            Debug.Log("OnBeginDrag");
            this.transform.SetParent(snapBackParent);
            this.transform.SetSiblingIndex(placeholder.transform.GetSiblingIndex());
            GetComponent<CanvasGroup>().blocksRaycasts = true;

            Destroy(placeholder);
            cardDraw = false;
        
    }


    public void attackButton()
    {

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Left Click");

        }


    }

}

