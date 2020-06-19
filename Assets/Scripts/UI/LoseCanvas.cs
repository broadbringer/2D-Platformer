using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCanvas : MonoBehaviour
{

    [SerializeField] private EventManager _eventManager;

    [SerializeField] private GameObject _loseCanvas;
    private void OnEnable()
    {
        _eventManager.OnHeroDeath += SetPause;
    }

    private void OnDisable()
    {
        _eventManager.OnHeroDeath -= SetPause;
    }
    private void SetPause()
    {
        _loseCanvas.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void CloseApplication()
    {
        Application.Quit();
    }
    
}
