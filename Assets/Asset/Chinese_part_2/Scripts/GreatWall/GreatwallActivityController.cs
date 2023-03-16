using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GreatwallActivityController : MonoBehaviour
{
    public Image greatWall;
    public Image Map;
    public Image MapZoomed;
    public AudioClip correctClip;
    public AudioClip wrongClip;
    public AudioClip victoryClip;
    public Button instructionButton;
    public Sprite instructionSprite;
    public Sprite closeSprite;
    public GameObject instructionOverlay1;
    public GameObject instructionOverlay2;
    public GameObject victoryOverlay;
    public static GreatwallActivityController instance;
    public static int correctCount = 0;
    private bool isOverlay;
    private bool isMapZoomed;


    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    private void Start()
    {
        SoundManager.Instance.Stop();
        greatWall.color = new Color32(255, 255, 255, 0);
        isOverlay = false;
        isMapZoomed = false;
        
    }

    private void Update()
    {
        if (correctCount == 7)
        {
            StartCoroutine(GameWon());
            correctCount = 0;
        }
    }

    public void OnGreatwallClick()
    {
        greatWall.color = new Color32(255, 255, 255, 255);
        SoundManager.Instance.Play(correctClip);
        Invoke("ZoomedMapEnabler", 2f);
    }

    public void OnMapClick()
    {
        SoundManager.Instance.Play(wrongClip);
    }

    public void ZoomedMapEnabler()
    {
        isMapZoomed = true;
        MapZoomed.gameObject.SetActive(true);
        Map.gameObject.SetActive(false);
    }

   public IEnumerator GameWon()
    {
        yield return new WaitForSeconds(5);
        SoundManager.Instance.Play(victoryClip);
        MapZoomed.gameObject.SetActive(false);
        Map.gameObject.SetActive(true);
        victoryOverlay.SetActive(true);
    }

    public void OnInstructionButtonClick()
    {
        if (!isOverlay && !isMapZoomed)
        {
            isOverlay = true;
            instructionOverlay1.SetActive(true);
            instructionButton.gameObject.GetComponent<Image>().sprite = closeSprite;
        }
        else if( !isOverlay && isMapZoomed)
        {
            isOverlay = true;
            instructionOverlay2.SetActive(true);
            instructionButton.gameObject.GetComponent<Image>().sprite = closeSprite;

        }
        else
        {
            isOverlay = false;
            instructionOverlay1.SetActive(false);
            instructionOverlay2.SetActive(false);
            SoundManager.Instance.Stop();
            instructionButton.gameObject.GetComponent<Image>().sprite = instructionSprite;

        }


    }


}
