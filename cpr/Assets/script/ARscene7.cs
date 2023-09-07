using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ARscene7 : MonoBehaviour
{
    public GameObject cube;

    void Start()
    {
        Invoke("Disappear", 48f);
        Invoke("home", 52f);
    }

    void Disappear()
    {
        cube.SetActive(false);
    }
    void home()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

}
