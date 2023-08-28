using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class call911 : MonoBehaviour
{
    public GameObject Button;
    public GameObject Talking;
    
    public void openbutton()
    {
        if(Button != null)
        {
            Button.SetActive(true);
        }
        if (Talking != null)
        {
            Talking.SetActive(true);
        }
    }
  
}
