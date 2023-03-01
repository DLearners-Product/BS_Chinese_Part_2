using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ocupations_navigation_Script : MonoBehaviour
{
    // declaring the images
    public Image farming;
    public Image fishing;
    public Image trade;
    public Image artAndCraft;
    // declaring the gameobjects
    public GameObject farmingSlide;
    public GameObject fishingSlide;
    public GameObject tradeSlide;
    public GameObject artAndCraftSlide;

    // Initial scale values
    Vector3 farminitscale;
    Vector3 fishinginitscale;
    Vector3 tradeinitscale;
    Vector3 artAndCraftinitscale;

   
    private void Start()
    {
         farminitscale = farming.transform.localScale;
         fishinginitscale = fishing.transform.localScale;
         tradeinitscale = trade.transform.localScale;
        artAndCraftinitscale = artAndCraft.transform.localScale;
      
    }
    // Functions to switch between slides
    public void OnFarmClick()
    {
        this.gameObject.SetActive(false);
        farmingSlide.SetActive(true);
        fishingSlide.SetActive(false);
        tradeSlide.SetActive(false);
        artAndCraftSlide.SetActive(false);
       
    }
    public void OnFishingClick()
    {
        this.gameObject.SetActive(false);
        farmingSlide.SetActive(false);
        fishingSlide.SetActive(true);
        tradeSlide.SetActive(false);
        artAndCraftSlide.SetActive(false);
 
    }
    public void OnTradeClick()
    {
        this.gameObject.SetActive(false);
        farmingSlide.SetActive(false);
        fishingSlide.SetActive(false);
        tradeSlide.SetActive(true);
        artAndCraftSlide.SetActive(false);
       
    }
    public void OnACClick()
    {
        this.gameObject.SetActive(false);
        farmingSlide.SetActive(false);
        fishingSlide.SetActive(false);
        tradeSlide.SetActive(false);
        artAndCraftSlide.SetActive(true);
    }

    
    //  Mouse Hover Effect functions

    // Mouse hover enter and exit function for farming image
    public void OnFarmMouseEnter()
    {
        farming.transform.localScale = new Vector3(6f, 6f, 0f);
    }
    public void OnFarmMouseExit()
    {
        farming.transform.localScale = farminitscale;
    }

    // Mouse hover enter and exit function for fishing image
    public void OnFishingMouseEnter()
    {
        fishing.transform.localScale = new Vector3(6f, 6f, 0f);
    }
    public void OnFishingMouseExit()
    {
        fishing.transform.localScale = fishinginitscale;
    }

    // Mouse hover enter and exit functions for trade image
    public void OnTradeMouseEnter()
    {
        trade.transform.localScale = new Vector3(6f, 5f, 0f);
    }
    public void OnTradeMouseExit()
    {
        trade.transform.localScale = tradeinitscale;
    }

    // Mouse hover enter and exit function for art and crafty image
    public void OnACMouseEnter()
    {
        artAndCraft.transform.localScale = new Vector3(6f, 5f, 0f);
    }
    public void OnACMouseExit()
    {
        artAndCraft.transform.localScale = artAndCraftinitscale;
    }


}
