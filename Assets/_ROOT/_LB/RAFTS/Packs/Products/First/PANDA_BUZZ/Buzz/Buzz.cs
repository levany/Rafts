using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using Random = UnityEngine.Random;

public class Buzz : MonoBehaviour, IPointerDownHandler
{
    // Types

    public enum State
    {
        Start,
        Ready,
        Buzz,
        End
    }

    // Members
    
    public List<Player> Players; 
    
    public State state = State.Start;
    
    public GameObject      MainMenu;
    public GameObject      Stage;
    public GameObject      ResultsPopup;
    
    public GameObject      PandaImage;
    public GameObject      DuckImage;
    
    public TextMeshProUGUI StageText;
    public GameObject      BuzzBG;
    public GameObject      BuzzWhiteBG;
    
    public GameObject      LeftBlack;
    public GameObject      rightBlack;
    
    public TextMeshProUGUI WinnerText;
    public TextMeshProUGUI PandasScoreText;
    public TextMeshProUGUI DucksScoreText;
    
    public int             PandasScore = 0;
    public int             DucksScore = 0;
    
    private bool           didStart = false;
    private bool           didClick;
    private Vector2        clickPosition;

    private void Awake()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    // Main flow
    
    void Start() => StartCoroutine(DoBuzz());
    public IEnumerator DoBuzz()
    {    
        START:
        
        ///////////////////////////////// Reset
        
        Debug.Log("Reset");
        
        MainMenu.gameObject.SetActive(false);
        Stage.gameObject.SetActive(false);
        ResultsPopup.gameObject.SetActive(false);
        didStart = false;
        didClick = false;
        BuzzBG.SetActive(false);
        BuzzWhiteBG.SetActive(false);
        StageText.gameObject.SetActive(true);
        PandaImage.SetActive(true);
        DuckImage.SetActive(true);
        LeftBlack.SetActive(false);
        rightBlack.SetActive(false);
        
        //////////////////////////////////////////////////////////// Menu Phase
        
        Debug.Log("Menu");
        
        MainMenu.gameObject.SetActive(true);
        
        yield return new WaitUntil(() => didStart);
        Debug.Log("Start Clicked");
        
        MainMenu.gameObject.SetActive(false);
        Stage.gameObject.SetActive(true);
        
        //////////////////////////////////////////////////////////// Ready Phase
        
        // Match started, but not time to buzz yet
        
        // Ready text
        StageText.text = "Ready..";
        Debug.Log("Ready Pahse");
        
        yield return new WaitForSeconds(3);
        
        //////////////////////////////////////////////////////////// Wait Phase
        
        didClick = false;
        StageText.gameObject.SetActive(false);
        Debug.Log("Wait Phase");
        
        // Definitions
        var startTime     = Time.timeSinceLevelLoad;
        int randomSeconds = (int)Random.Range(3, 8);
        
        string winner = "None";
        
        // Start Wait phase
        
        while (Time.timeSinceLevelLoad < startTime + randomSeconds)
        {
            if (didClick)
            {
                if (clickPosition.x < Screen.width / 2)
                {
                    winner = "Ducks";
                }
                else
                {
                    winner = "Pandas";
                }
                
                Debug.Log("Clicked Too early - winner is : " + winner);
                
                goto END;
                
            }
            
            yield return null;
        }
        
        //////////////////////////////////////////////////////////// Buzz Phase
        
        // Time to buzz

        Debug.Log("Buzz Phase");

        StageText.gameObject.SetActive(true);
        BuzzBG.gameObject.SetActive(true);
        BuzzWhiteBG.SetActive(true);
        StageText.text = "BUZZ !";

        do
        {
            winner = null;
            
            if (didClick)
            {
                if (clickPosition.x < Screen.width / 2)
                {
                    winner = "Pandas";
                }
                else
                {
                    winner = "Ducks";
                }
                
                goto END;   
            }
            
            yield return null;
        } 
        while (winner == null);
        
        
        ////////////////////////////////////////////////////////////
    
        END:
        
        Debug.Log("End Phase");

        if (winner == "Pandas")
        {
            DuckImage.SetActive(false);
            rightBlack.SetActive(true);
            PandasScore++;
        }
        else
        {
            PandaImage.SetActive(false);
            LeftBlack.SetActive(true);
            DucksScore++;
        }
        
        StageText.gameObject.SetActive(false);
        BuzzBG.gameObject.SetActive(false);
        BuzzWhiteBG.SetActive(false);
        
        yield return new WaitForSeconds(2);
        
        didStart = false;
        
        PandasScoreText.text = PandasScore.ToString();
        DucksScoreText.text  = DucksScore.ToString();
        
        Stage.gameObject.SetActive(false);
        ResultsPopup.gameObject.SetActive(true);
        WinnerText.text = winner + " Win !";
        
        yield return new WaitUntil(() => didStart == true);
        
        goto START;
        
        yield break;
    }
    
    
    // Events
    
    public void OnStartClicked()
    {
        Debug.Log("OnStartClicked");
        didStart = true;   
    }
    
    public void OnRestartClicked()
    {
        Debug.Log("OnRestartClicked");
        didStart = true;
    }

    public void OnPointerDown(PointerEventData e)
    {
        Debug.Log("Pointer click at : " + e.position);
        didClick = true;
        clickPosition = e.position;
    }
}

