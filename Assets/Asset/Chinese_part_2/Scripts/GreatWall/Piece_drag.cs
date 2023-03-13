using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Piece_drag : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    Vector2 mousePos;
    Camera mainCam;
    public CanvasGroup canvasGroup;

    public Transform originalParent = null;


    private void Awake()
    {
        mainCam = Camera.main;
        canvasGroup = GetComponent<CanvasGroup>();
        originalParent = this.transform.parent;

    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        this.transform.SetParent(originalParent.parent.parent.parent);
        canvasGroup.alpha = .5f;
        canvasGroup.blocksRaycasts = false;


    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = mousePos;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        canvasGroup.alpha = 1f;
        this.transform.SetParent(originalParent);
        canvasGroup.blocksRaycasts = true;


    }


}
