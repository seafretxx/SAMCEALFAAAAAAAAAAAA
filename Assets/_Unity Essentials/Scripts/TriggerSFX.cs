using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class TriggerSFX : MonoBehaviour
{
    public AudioSource audioSource;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            audioSource.Play();
        }
    }
}
