using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Between1to2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void btnRestart()
    {
        Debug.Log("Restart level");
    }
    public void btnNextLeve()
    {
        Debug.Log("Next level");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void btnQuit()
    {
        Debug.Log("Quit game");
        Application.Quit();
    }
    
}
