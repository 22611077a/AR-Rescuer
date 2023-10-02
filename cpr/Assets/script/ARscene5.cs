using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARscene5 : MonoBehaviour
{
    public GameObject Talking;
    public GameObject running;
    public GameObject Aed;

    void Start()
    {
        Invoke("call119", 2f);
        Invoke("aed", 4f); 
        Invoke("end", 6f);
    }
    void call119()
    {
        Talking.SetActive(true);
    }
    void aed()
    {
        running.SetActive(true);
        Aed.SetActive(true);
    }
    void end()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(6);
    }
}
