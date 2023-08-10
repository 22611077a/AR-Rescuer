using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Timer : MonoBehaviour
{
    public GameObject Text2;
    public GameObject Text;

    void Start()
    {
        Invoke("Disappear", 3f);
        Invoke("end", 5f);
    }

    void Disappear()
    {
        Text.SetActive(false);
        
    }
    void end()
    {
        Text2.SetActive(true);
    }

}
