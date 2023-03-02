using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Quiz_controller : MonoBehaviour
{
    
    private static Quiz_controller instance;
    public static Quiz_controller Instance { get { return instance; } }
    public GameObject[] Q;
    public Button nextbutton;
    private int i;
    public Color correctAnsColor, _correctAnsColor;
   

    private void Awake()
    {
        if (instance)
            Destroy(this.gameObject);

        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    private void Start()
    {
        i = 0;
        nextbutton.gameObject.SetActive(false);

    }

    public void OnNextButtonClick()
    {
        if (i < Q.Length)
        {
            i++;
            Q[i-1].SetActive(false);
            Q[i].SetActive(true);
            nextbutton.gameObject.SetActive(false);
            
        }
        if(i== Q.Length-1)
        {
            nextbutton.gameObject.SetActive(false);
        }

        else { return; }
        
    }

    public void CheckCorrectAnswer()
    {
        Debug.Log("check CheckCorrectAnswer");
        GameObject selectedOption = Q[i].transform.Find("Options_Image_holder").GetComponent<ToggleGroup>().ActiveToggles().FirstOrDefault().gameObject;
        if (selectedOption.name.Contains("Answer") && i< Q.Length-1)
        {
            nextbutton.gameObject.SetActive(true);
        }
    }

   
}
