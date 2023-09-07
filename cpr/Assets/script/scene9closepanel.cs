using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene9closepanel : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Panel2;
    public GameObject plane;
    public GameObject plane2;
    public GameObject Text3;
    public GameObject Text2;
    public GameObject Text1;

    void Start()
    {
        Invoke("Disappear", 5f);
        Invoke("end", 14f);
        Invoke("panal2", 18f);
        Invoke("three", 24f);
        Invoke("two", 25f);
        Invoke("one", 26f);
        Invoke("home", 27f);
    }

    void Disappear()
    {
        Panel.SetActive(false);
    }
    void end()
    {
        plane.SetActive(false);
        plane2.SetActive(false);
        
    }
    void panal2()
    {
        Panel2.SetActive(true);
    }
    void three()
    {
        Panel2.SetActive(false);
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
