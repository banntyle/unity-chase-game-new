using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscene : MonoBehaviour 
{

    public string StartingScene = "";
    public double Delay = 0;

    private double elapsedTime = 0;

    void update()

    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > Delay)
        {   
            SceneManager.LoadScene(StartingScene);
        }
    }
}
