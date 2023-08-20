using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb2 : MonoBehaviour
{
    public GameObject cube;
    public GameObject cube1;
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
        cube1.SetActive(false);
        cube.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cube.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
