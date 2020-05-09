using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectRelic : MonoBehaviour
{
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        ScoringSystem.theScore += 1;
        Destroy(gameObject);
        if (ScoringSystem.theScore == 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
