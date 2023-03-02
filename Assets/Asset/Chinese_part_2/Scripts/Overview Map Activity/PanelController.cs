using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour
{
    public Button closeButton;

    private void Start()
    {
        closeButton.gameObject.SetActive(true);
    }
    public void OnCloseButtonClick()
    {
        this.gameObject.SetActive(false);
        closeButton.gameObject.SetActive(false);
    }
}
