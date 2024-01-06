using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinsound;

    private void OnTriggerEnter(Collider other) 
    {
        coinsound.Play();
        this.gameObject.SetActive(false);
        Destroy(gameObject);
        ScoreManager.scoreCount += 1;
    }
}
