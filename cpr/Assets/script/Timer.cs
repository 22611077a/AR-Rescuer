using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Timer : MonoBehaviour
{
    public GameObject Text;
    public GameObject Text0;
    public GameObject Text3;
    public GameObject Text2;
    public GameObject Text1;

    void Start()
    {
        Invoke("Disappear", 4f);
        Invoke("end", 5f);
        Invoke("three", 8f);
        Invoke("two", 9f);
        Invoke("one", 10f);
        Invoke("home", 11f);
    }

    void Disappear()
    {
        Text0.SetActive(false);
        
    }
    void end()
    {
        Text.SetActive(true);
    }
    void three()
    {
        Text3.SetActive(true);
    }
    void two()
    {
        Text3.SetActive(false);
        Text2.SetActive(true);
    }
    void one()
    {
        Text2.SetActive(false);
        Text1.SetActive(true);
    }
    void home()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

}
