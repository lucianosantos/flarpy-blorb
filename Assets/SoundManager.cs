using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public void Play(string soundname)
    {
        // Get child component with name soundname and play it
        transform.Find(soundname).GetComponent<AudioSource>().Play();
    }

    public void Stop(string soundname)
    {
        // Get child component with name soundname and stop it
        transform.Find(soundname).GetComponent<AudioSource>().Stop();
    }

    public void StopAll()
    {
        // Get all child components and stop them
        foreach (Transform child in transform)
        {
            child.GetComponent<AudioSource>().Stop();
        }
    }
}
