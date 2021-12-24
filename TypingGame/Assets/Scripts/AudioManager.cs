using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    public enum Sounds
    {
        LetterRemove
    }

    public AudioClip audioClip;
    private AudioSource audioSorce;

    private void Start()
    {
        audioSorce = GetComponent<AudioSource>();
    }

    public void PlayAudioLetterRemove(Sounds sound)
    {
        switch (sound)
        {
            case Sounds.LetterRemove:
                audioSorce.PlayOneShot(audioClip);
                break;
            default:
                break;
        }
    }
}
