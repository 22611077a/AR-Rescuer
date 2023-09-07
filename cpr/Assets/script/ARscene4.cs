using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARscene4 : MonoBehaviour
{

    void Start()
    {
        Invoke("home", 7f);
    }

    void home()
    {
       UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
