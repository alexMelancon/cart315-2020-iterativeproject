using System.Collections;
// Unity UI is important to include if there is a variable that relates to a TextMesh Pro text.
using UnityEngine.UI;
using UnityEngine;
// Unity SceneManagement is important to include if there is a function that called a change in scenes.
using UnityEngine.SceneManagement;


public class End : MonoBehaviour
{
    // Score from the Food script
    public int Score
    {
        get { return Score; }
        set { Score = value; }
    }

    // Text that will hold the Score
    public Text scoreText;

    public void Update()
    {
        // Get the Score and insert it into a text
        scoreText.text = Food.Score.ToString();
    }

}
