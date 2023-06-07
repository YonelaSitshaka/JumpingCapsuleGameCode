using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseFunction : MonoBehaviour
{
    public GameObject ObjPlayer;
   
    public GameObject btnpause2;
    public GameObject pnlPause;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private float oldYPoition;
    public void btnLeve2Pause()
    {
        ObjPlayer.gameObject.SetActive(false);
        pnlPause.SetActive(true);
        btnpause2.SetActive(false);

    }
    public void btnLeve2Play()
    {
        ObjPlayer.gameObject.SetActive(true);
        pnlPause.SetActive(false);
        btnpause2.SetActive(true);
    }
    public void btnNewGame()
    {
        SceneManager.LoadScene(0);
    }
    public void btnRestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void btnQuit()
    {
        Application.Quit();
    }
}
