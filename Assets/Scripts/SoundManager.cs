using Cinemachine.PostFX;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;


public class SoundManager : MonoBehaviour
{
    [Header("Parameters")]
    [SerializeField] private AudioSource music;
    [SerializeField] private AudioSource sound;
    [SerializeField] private Image musicButtonOn;
    [SerializeField] private Image soundButtonOn;
    [SerializeField] private Sprite musicButtonOff;
    [SerializeField] private Sprite musicButtonOnImage;
    [SerializeField] private Sprite soundButtonOff;
    [SerializeField] private Sprite soundButtonOnImage;


    private float soundVolume = 1f;
    private float musicVolume = 0.412f;


    public void OffSounds()
    {
        if (soundVolume == 1f)
        {
            soundVolume = 0f;
            sound.volume = soundVolume;
            soundButtonOn.sprite = soundButtonOff;

        }
        else if (soundVolume == 0f)
        {
            soundVolume = 1f;
            sound.volume = soundVolume;
            soundButtonOn.sprite = soundButtonOnImage;

        }
        
    }
    public void OffMusic()
    {
        if (musicVolume == 0.412f)
        {
            musicVolume = 0f;
            music.volume = musicVolume;
            musicButtonOn.sprite = musicButtonOff;
        }
        else if (musicVolume == 0f)
        {
            musicVolume = 0.412f;
            music.volume = musicVolume;
            musicButtonOn.sprite = musicButtonOnImage;
        }

    }


}
