using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Takeaed : MonoBehaviour
{
    public GameObject running;
    
    public void openrunnung()
    {
        if (running != null)
        {
            running.SetActive(true);
        }
       
    }
}
