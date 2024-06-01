using UnityEngine.Audio;
using UnityEngine;
using System;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine.UI;
using System.Collections.Generic;

public class AudioManager : MonoBehaviour
{
    //Script based off tutorial: https://www.youtube.com/watch?v=6OT43pvUyfY&t=2s&ab_channel=Brackeys


    public Slider musicSlider;
    public Slider sfxSlider;

    public bool muted = false;
    public Sound[] sounds;                   //This Audio Manager is here to easily play sounds
                                             //Sounds from here will not be played in 3D space
    public static AudioManager instance;     //Play sounds from the Audio Manager with "FindObjectOfType<AudioManager>().Play("sound_name");"
                                             //This works from any script

    public List<AudioSource> audioSourceList;
    public List<float> originalVolumes;

    void Awake()
    {
        musicSlider = GameObject.Find("MusicSlider").GetComponent<Slider>();
        sfxSlider = GameObject.Find("SfxSlider").GetComponent<Slider>();
        audioSourceList = new List<AudioSource>();

        if (instance == null)             //This code allows the audio manager to remain constant between scenes
            instance = this;              //and ensures there is only ever one Audio Manager
        else
        {
            Destroy(gameObject);
            return;
        }
        //DontDestroyOnLoad(gameObject);  

        foreach (Sound s in sounds)                   //Creates an audio source for each sound clip in the array
        {                                             //You can access the sounds array from the Audio Manager object in the inspector
            s.source = gameObject.AddComponent<AudioSource>();
            audioSourceList.Add(s.source);

            s.source.clip = s.clip;
            s.source.volume = s.volume;               //Copies all the given information for the audio source.
            originalVolumes.Add(s.volume);

            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
        //Play("Music");

        AudioSource[] audioSources = GetComponents<AudioSource>();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.M)) //Mute button for debugging purposes.
        {
            FindObjectOfType<AudioListener>().enabled = muted;
            muted = !muted;

        }
    }

    public void Play(string name)   //Find the sound in the sound array where sound.name = the string passed into Play()
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

    public void StopPlaying(string sound)  //Stops a sound playing before it has finished playing
    {
        Sound s = Array.Find(sounds, item => item.name == sound);
        s.source.Stop();
    }


    public bool IsPlaying(string sound)   //Checks if a sound is playing
    {
        Sound s = Array.Find(sounds, item => item.name == sound);
        return s.source.isPlaying;
    }

    public void SetPitch(string sound, float p)  //Sets the pitch of a sound during runtime
    {
        Sound s = Array.Find(sounds, item => item.name == sound);
        s.pitch = p;
    }

    public void ChangeMusicVolume()
    {
        
    }

    public void ChangeSfxVolume() 
    {
        
        foreach (var audioSource in audioSourceList)
        {
            
            if (audioSource.clip != null && !audioSource.clip.name.Contains("Music"))
            {
                
                audioSource.volume = originalVolumes[audioSourceList.IndexOf(audioSource)] * sfxSlider.value;
                
            }
        }
    }
}
