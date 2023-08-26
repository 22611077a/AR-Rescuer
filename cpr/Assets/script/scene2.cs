using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene2 : MonoBehaviour
{

    public GameObject buttonfinish;
    void Start()
    {
        Invoke("button", 5f);
    }
    public void button()
    {
        buttonfinish.SetActive(true);
    }
}
