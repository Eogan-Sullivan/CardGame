using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

 public  class DropZone : MonoBehaviour,IDropHandler {

    public bool cardDraw = true;
    public void OnPointerEnter(PointerEventData eventData)
    {
       Debug.Log("OnPointerEnter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("OnPointerExit");
    }
    public void OnDrop(PointerEventData eventData)
    {
        if (cardDraw == true && GameObject.FindGameObjectWithTag("Game").GetComponent<NewPhase>().currentPhase == NewPhase.Phases.redMainPhase)
        {
            Debug.Log("ONDrop to" + gameObject.name);


            Dragable d = eventData.pointerDrag.GetComponent<Dragable>();
            if (tag == "RedMonsterZone") d.DroppedinMonsterZone();
            if (d != null)
            {
                d.snapBackParent = this.transform;
            }

            cardDraw = false;
                  
        }

        else if (cardDraw == true && GameObject.FindGameObjectWithTag("Game").GetComponent<NewPhase>().currentPhase == NewPhase.Phases.blueMainPhase)
        {
            Debug.Log("ONDrop to" + gameObject.name);


            Dragable d = eventData.pointerDrag.GetComponent<Dragable>();
            if (tag == "BlueMonsterZone") d.DroppedinMonsterZone();
            if (d != null)
            {
                d.snapBackParent = this.transform;
            }

            cardDraw = false;

        }
    }
}
