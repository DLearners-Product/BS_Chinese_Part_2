using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Intro_controller : MonoBehaviour
{
    public GameObject[] introImages;
    public Button nextButton;
    public Button closeButton;
    public GameObject OverlayPanel;
    private int i;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        introImages[i].GetComponent<Animator>().enabled = true;
    }

    public void OnNextButtonClick()
    {
        if (i < introImages.Length)
        {
            i++;
            introImages[i].GetComponent<Animator>().enabled = true;
        }
        if (i == introImages.Length - 1)
        {
            nextButton.gameObject.SetActive(false);
            Invoke("PanelEnabler", 10f);
        }
        else
        {
            return;
        }



    }
    public void PanelEnabler()
    {
        OverlayPanel.SetActive(true);
    }
    public void Closebutton()
    {
        OverlayPanel.SetActive(false);
    }
}
