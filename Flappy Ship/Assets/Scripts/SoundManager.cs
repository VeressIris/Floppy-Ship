using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip jumpSound;
    public AudioClip deathSound;
    public AudioClip pointSound;

    private AudioSource audioSrc;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();

        jumpSound = Resources.Load<AudioClip>("jump");
        deathSound = Resources.Load<AudioClip>("death");
        pointSound = Resources.Load<AudioClip>("point");
    }

    public void PlaySound(string clip)
    {
        switch(clip)
        {
            case "jump":
                audioSrc.PlayOneShot(jumpSound);
                break;
            case "death":
                audioSrc.PlayOneShot(deathSound);
                break;
            case "point":
                audioSrc.PlayOneShot(pointSound);
                break;
        }
    }
}
