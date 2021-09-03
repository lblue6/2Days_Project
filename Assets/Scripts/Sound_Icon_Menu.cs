using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Icon_Menu : MonoBehaviour
{

    public AudioSource iconsource;
    public AudioClip clip;

    
    void Start()
    {
        iconsource.clip = clip;



        
    }

    public void play_on()
    {
        iconsource.Play();
        
    }
}
