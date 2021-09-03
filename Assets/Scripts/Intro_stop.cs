using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;

using UnityEngine;

public class Intro_stop : MonoBehaviour
{


    public VideoPlayer video;


    void Awake()
    {

        video = GetComponent<VideoPlayer>();
        video.Play();
        video.loopPointReached += CheckOver;


    }

    void Start()

    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void CheckOver(VideoPlayer vp)

    {

             gameObject.SetActive(false);
        }

}
