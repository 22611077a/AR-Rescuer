using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class scene7end : MonoBehaviour
{
    public GameObject cube;
    public GameObject panel;
    public GameObject Text3;
    public GameObject Text2;
    public GameObject Text1;


    void Start()
    {
        Invoke("Disappear", 48f);
        Invoke("three", 51f);
        Invoke("two", 52f);
        Invoke("one", 53f);
        Invoke("home", 54f);
    }

    void Disappear()
    {
        cube.SetActive(false);
        panel.SetActive(true);
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
