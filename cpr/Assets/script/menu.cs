using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    public GameObject Panel;
    public GameObject background;

    public void open()
    {
        Panel.SetActive(true);
        background.SetActive(true);
    }

    public void close()
    {
        Panel.SetActive(false);
        background.SetActive(false);
    }

}
