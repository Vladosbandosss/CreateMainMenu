using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    private const string Play = "Game";
    private const string Menu = "Menu";

    [SerializeField] private GameObject _menuPanel;

   private void Start()
    {
        _menuPanel.SetActive(true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(Play);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(Menu);
    }

    
}
