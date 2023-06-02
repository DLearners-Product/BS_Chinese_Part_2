using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;

public class SummaryTextSlot : MonoBehaviour, IDropHandler
{
    public List<string> correctAnswers;
    private int i;
   private void Start()
    {
        i = 0;
    }

    public void OnDrop(PointerEventData eventData)
    {
       Debug.Log("OnDrop");

        SummaryTextDrag dragitem = eventData.pointerDrag.GetComponent<SummaryTextDrag>();

        if (dragitem != null)
        {
           
            if (  correctAnswers.Contains(dragitem.GetComponent<TextMeshProUGUI>().text))
            {
                for ( i = 0; i < correctAnswers.Count; i++)
                {
 
                    dragitem.originalParent = this.transform;
                    dragitem.transform.SetParent(this.transform);
                    dragitem.transform.localPosition = dragitem.originalParent.transform.position;
                    dragitem.canvasGroup.alpha = 1f;
                    dragitem.transform.localScale = new Vector3(0.55f, 0.55f, 0);
                    if (dragitem.originalParent == this.transform)
                    {
                        dragitem.enabled = false;
                    }

                }
                SummaryActivityController.correctCount++;
                Debug.Log(SummaryActivityController.correctCount);
            }
            else
            {
                return;
            }


        }



    }
}

