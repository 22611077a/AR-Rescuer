using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARscene4 : MonoBehaviour
{

    void Start()
    {
        Invoke("home", 5f);
    }

    void home()
    {
       UnityEngine.SceneManagement.SceneManager.LoadScene(22);
    }
}
