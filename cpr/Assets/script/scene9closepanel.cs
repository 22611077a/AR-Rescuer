using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene9closepanel : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Panel2;

    void Start()
    {
        Invoke("Disappear", 3f);
        Invoke("end", 14f);
    }

    void Disappear()
    {
        Panel.SetActive(false);
    }
    void end()
    {
        Panel2.SetActive(true);
    }

}
