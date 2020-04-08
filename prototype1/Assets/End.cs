using System.Collections;
// Unity UI is important to include if there is a variable that relates to a TextMesh Pro text.
using UnityEngine.UI;
using UnityEngine;
// Unity SceneManagement is important to include if there is a function that called a change in scenes.
using UnityEngine.SceneManagement;
using TMPro;


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
    // Text that will hold the description
    public TextMeshProUGUI description;

    public void Start()
    {
        
    }
    public void Update()
    {
        // Get the Score and insert it into a text
        scoreText.text = Food.Score.ToString();
        if (Food.Score == 0)
        {
            description.text = "Can't travel with an empty stomach, can we?";
        }
        if (Food.Score > 0 && Food.Score < 30)
        {
            description.text = "You surely ate a lot, or at least tried to! See below how much did you grow from all of that!";
        }
        if (Food.Score > 30)
        {
            description.text = "An impressive score! Think you can fill the whole planet with your tail?";
        }
    }

}
