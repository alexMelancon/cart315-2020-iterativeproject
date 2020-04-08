using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Unity SceneManagement is important to include if there is a function that called a change in scenes.
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public GameObject Player;
    // Score from the Food script
    public int Score
    {
        get { return Score; }
        set { Score = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        // Make this script variable refered as the Player gameObject
        Player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
    }

    // When the snake touches any death object
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player) //The Player object represents the snake's head only. Any impact on the tail won't trigger change
        {
            //Debug.Log("Death");
            //Debug.Log(this.gameObject.name);
            // Game Over screen
            //Wait a while before jumping to the gameover screen directly
            StartCoroutine(Wait());
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.5f);
    }

}
