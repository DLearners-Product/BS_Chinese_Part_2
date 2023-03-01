using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Quiz_controller : MonoBehaviour
{
    
    private static Quiz_controller instance;
    public static Quiz_controller Instance { get { return instance; } }
    public GameObject[] Q;
    public Button nextbutton;
    public GameObject correctanswer;
    private int i;
   

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
    }

    public void OnNextButtonClick()
    {
        if (i < Q.Length)
        {
            i++;
            Q[i-1].SetActive(false);
            Q[i].SetActive(true);
            
        }
        if(i== Q.Length-1)
        {
            nextbutton.gameObject.SetActive(false);
        }

        else { return; }
        
    }

   
}
