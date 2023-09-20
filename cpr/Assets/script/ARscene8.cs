using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ARscene8 : MonoBehaviour
{
    public GameObject cube;
    public VideoPlayer tempo;
    public GameObject cubetempo;
    public GameObject panel;
    public GameObject panel2;

    void Start()
    {
        Invoke("Disappear", 5f);
        Invoke("tempo1", 20f);
        Invoke("con", 32f);
        Invoke("restart", 44f);
    }
    void Disappear()
    {
        panel.SetActive(false);
    }
    void tempo1()
    {
        cubetempo.SetActive(true);
        tempo.Play();
    }
    void con()
    {
        cube.SetActive(false);
        panel2.SetActive(true);
    }
    void restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(8);
    }
}