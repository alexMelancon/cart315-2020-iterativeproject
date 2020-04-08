using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    private Transform PlayerTransform;
    public Transform TeleportGoal;
    public GameObject Player;

    void Start()
    {
        PlayerTransform = Player.transform;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            PlayerTransform.position = TeleportGoal.position;
            Debug.Log(TeleportGoal.position);
            //Time.timeScale = 0;
        }
    }
}
