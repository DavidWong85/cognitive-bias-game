using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaySound : MonoBehaviour
{
    public AudioSource soundSource;

    public void playSoundEffect()
    {
        soundSource.Play();
    }
}

