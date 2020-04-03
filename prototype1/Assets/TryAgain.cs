using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Unity SceneManagement is important to include if there is a function that called a change in scenes.
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour
{
    public void StartAgain()
    {
        // Goes to the 'Game' scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
