using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    private AudioSource audio;

    // Start is called before the first frame update
    void Awake()
    {
        audio.GetComponent<AudioSource>();
    }

    public void PlayAudio()
    {
        audio.Play();
    }
}
