using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : Singleton<SoundManager>
{
    public AudioSource bgSource;
    public AudioSource efSource;

    public AudioClip bgSound;
    public Sound sound;

    
    public bool isBGSource = true;
    private void Start()
    {
        PlayBackGround();
    }
    public void PlayBackGround()
    {
        if (isBGSource)
        {
            bgSource.clip = bgSound;
            bgSource.loop = true;
            bgSource.Play();
        }
        else
        {
            bgSource.Stop();
        }
    }   
    public void PlaySound(AudioClip sound)
    {
        efSource.PlayOneShot(sound);
    }
}
[System.Serializable]
public class Sound
{  
    public AudioClip testSoundClip;
    public void Play() 
    {
        SoundManager.Instance.PlaySound(testSoundClip);
    }
}
