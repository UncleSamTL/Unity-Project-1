using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Press : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playgame()
    {
        SceneManager.LoadScene("Assesment");
    }
    public void Quit()
    {

        Application.Quit();
    }
    public void ResetCounter()
    {
        PlayerPrefs.SetInt("Attempts", 0);
    }
}
