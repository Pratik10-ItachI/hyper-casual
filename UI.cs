using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
    public GameObject GameOverUI;
    void Start()
    {
        PauseMenuUI.SetActive(false);
        GameOverUI.SetActive(false);
    }
    void Update()
    {

    }
    public void Pause_button()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Replay()
    {
        PauseMenuUI.SetActive(false);
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Main_menu()
    {
        PauseMenuUI.SetActive(false);
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }
}
