using Cinemachine.PostFX;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;


public class SoundManager : MonoBehaviour
{
    [Header("Component")]
    [SerializeField] private AudioSource music;
    [SerializeField] private AudioSource sound;
    [SerializeField] private AudioSource victoryMusic;

    [Header("Images")]
    [SerializeField] private Image musicButtonOn;
    [SerializeField] private Image soundButtonOn;

    [SerializeField] private Sprite musicButtonOff;
    [SerializeField] private Sprite musicButtonOnImage;
    [SerializeField] private Sprite soundButtonOff;
    [SerializeField] private Sprite soundButtonOnImage;

    [Header("Objects")]
    [SerializeField] private GameObject victoryPanel;
    [SerializeField] private GameObject shopCanvas;



    private float soundVolume = 1f;
    private float musicVolume = 0.412f;
    private float victoryMusicVolume = 0.300f;

    private void Start()
    {
        victoryMusic.volume = victoryMusicVolume;

    }

    public void OnVictoryMusic()
    {
        sound.volume = 0f;
        music.volume = 0f;
        victoryMusic.enabled = true;

    }
    private void Update()
    {
        if (shopCanvas.activeInHierarchy && musicButtonOn.sprite == musicButtonOnImage)
        {
            musicVolume = 0.412f;
            music.volume = musicVolume;
        }
    }




    public void OffSounds()
    {
        switch (soundVolume)
        {
            case 1f:
                soundVolume = 0f;
                sound.volume = soundVolume;
                soundButtonOn.sprite = soundButtonOff;
                break;
            case 0f:
                soundVolume = 1f;
                sound.volume = soundVolume;
                soundButtonOn.sprite = soundButtonOnImage;
                break;

        }

    }
    public void OffMusic()
    {

        switch (musicVolume)
        {
            case 0.412f:
                musicVolume = 0f;
                music.volume = musicVolume;
                musicButtonOn.sprite = musicButtonOff;
                break;

            case 0f:
                musicVolume = 0.412f;
                music.volume = musicVolume;
                musicButtonOn.sprite = musicButtonOnImage;
                break;

        }

    }
}
