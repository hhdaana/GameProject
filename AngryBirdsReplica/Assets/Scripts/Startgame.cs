using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startgame : MonoBehaviour
{
    public string LevelName;

    public void LoadLevel()
    {
        Debug.Log("" + LevelName);
        SceneManager.LoadScene(LevelName);
    }

    public void LoadBackTo()
    {
        SceneManager.LoadScene(LevelName);
    }
}
