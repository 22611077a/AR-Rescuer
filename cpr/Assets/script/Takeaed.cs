using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Takeaed : MonoBehaviour
{
    public GameObject running;
    public GameObject Button;
    public GameObject Aed;

    public void openrunnung()
    {
        if (running != null)
        {
            running.SetActive(true);
        }
        if (Button != null)
        {
            Button.SetActive(true);
        }
        if (Aed != null)
        {
            Aed.SetActive(true);
        }

    }
}
