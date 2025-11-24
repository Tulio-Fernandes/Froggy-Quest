using UnityEngine;

public class MusicManager : MonoBehaviour
{

    public AudioSource audioSource;

    private void Awake()
    {
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();
    }

    public void StopMusic()
    {
        if (audioSource != null)
            audioSource.Stop();
    }

    public void PlayMusic()
    {
        if (audioSource != null && !audioSource.isPlaying)
            audioSource.Play();
    }
}
