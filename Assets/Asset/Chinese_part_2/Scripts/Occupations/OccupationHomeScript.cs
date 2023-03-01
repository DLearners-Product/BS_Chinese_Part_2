using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OccupationHomeScript : MonoBehaviour
{
    public Button backButton;
    public GameObject HomeSlide;

   
    private void FixedUpdate()
    {
        backButton.gameObject.SetActive(true);
    }
    public void OnBackButtonClick()
    {
        this.gameObject.SetActive(false);
        HomeSlide.SetActive(true);
        backButton.gameObject.SetActive(false);
    }
}
