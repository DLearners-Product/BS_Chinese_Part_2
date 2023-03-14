using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Piece_Slot : MonoBehaviour, IDropHandler
{
    public GameObject correctAnswer;
  

    public void OnDrop(PointerEventData eventData)
    {
         Debug.Log("OnDrop");

        Piece_drag dragitem = eventData.pointerDrag.GetComponent<Piece_drag>();

        if (dragitem != null)
        {

            if (dragitem.gameObject.name == correctAnswer.name)
           {
                    dragitem.originalParent = this.transform;
                    dragitem.transform.SetParent(this.transform);
                    dragitem.transform.position = this.transform.position;
                    dragitem.transform.localScale = this.transform.localScale;
                    if (dragitem.originalParent == this.transform)
                    {
                        dragitem.enabled = false;
                    }

                
            }
            else
            {
                return;
            }


        }



    }
}

