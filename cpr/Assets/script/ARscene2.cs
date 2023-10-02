using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARscene2 : MonoBehaviour
{
    void Start()
    {
        Invoke("end", 5f);
    }

    void end()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(3);
    }
}
