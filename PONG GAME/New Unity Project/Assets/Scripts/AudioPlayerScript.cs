using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayerScript : MonoBehaviour {

    private AudioSource audioSource;

    static bool AudioBegin = false;
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();

        if (!AudioBegin)
        {
            audioSource.Play();
            DontDestroyOnLoad(gameObject);
            AudioBegin = true;
        }
    }
    void Update()
    {
        if (Application.loadedLevelName == "winScene")
        {
            audioSource.Stop();
            AudioBegin = false;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
}
