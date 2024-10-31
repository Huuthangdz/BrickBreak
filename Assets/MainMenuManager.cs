using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenuManager : MonoBehaviour
{
    public GameObject ButtonPanel;
    public GameObject PlayButton;

    public Button playButton;
    public Button BackButton;
    public Button Level1;
    public Button Level2;
    public Button Level3;
    public Button Level4;
    public Button Level5;

    public enum MainMenuState
    {
        Menu,
        game,
        level1,
        level2,
        level3,
        level4,
        level5
    }
    // Start is called before the first frame update
    void Start()
    {
        InitPanel(MainMenuState.Menu);
        playButton.onClick.AddListener(() => InitPanel(MainMenuState.game));
        BackButton.onClick.AddListener(() => InitPanel(MainMenuState.Menu));



        Level1.onClick.AddListener(() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0));
        Level2.onClick.AddListener(() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
        Level3.onClick.AddListener(() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2));
        Level4.onClick.AddListener(() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3));
        Level5.onClick.AddListener(() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4));
    }

    public void InitPanel( MainMenuState state)
    {
        if ( state == MainMenuState.Menu)
        {
            ButtonPanel.SetActive(true);
            PlayButton.SetActive(false);
        }
        if ( state == MainMenuState.game)
        {
            ButtonPanel.SetActive(false);
            PlayButton.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
