using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleCollison : MonoBehaviour
{
    public GameObject player;
    public GameObject model;

    void OnTriggerEnter()
    {
       this.gameObject.GetComponent<BoxCollider>().enabled = false;
        player.GetComponent<PlayerMovement>().enabled = false;
        model.GetComponent<Animator>().Play("Stumble");
    }
}
