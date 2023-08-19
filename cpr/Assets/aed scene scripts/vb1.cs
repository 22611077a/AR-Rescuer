using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb1 : MonoBehaviour
{
    public GameObject cube;

    public VirtualButtonBehaviour vb;

    // Start is called before the first frame update
    void Start()
    {
        vb.RegisterOnButtonPressed(OnButtonPressed);
        vb.RegisterOnButtonReleased(OnButtonReleased);

        cube.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cube.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cube.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
