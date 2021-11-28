using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    AudioSource audioSoynd;

    // Start is called before the first frame update
    void Start()
    {
        audioSoynd = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        audioSoynd.mute = SounMute.soundMute;
    }

}
