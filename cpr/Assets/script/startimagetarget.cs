using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class startimagetarget : MonoBehaviour
{
    public GameObject ImageTarget;
    public GameObject Panel1;
    public GameObject cube;
    //public VideoPlayer video;

    void Start()
    {
        Invoke("image", 7f);
    }

    public void image()
    {
        Panel1.SetActive(false);
        ImageTarget.SetActive(true);
    }

    public void target()
    {
        cube.SetActive(true);
        //video.Play();
    }

}
