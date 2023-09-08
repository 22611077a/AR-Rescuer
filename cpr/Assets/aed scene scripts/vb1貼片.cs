using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb1貼片 : MonoBehaviour
{
    public GameObject cube;
    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;
    public VirtualButtonBehaviour vb;

    // Start is called before the first frame update
    void Start()
    {
        vb.RegisterOnButtonPressed(OnButtonPressed);
        vb.RegisterOnButtonReleased(OnButtonReleased);

        cube.SetActive(false);
        cube1.SetActive(false);
        cube2.SetActive(false);
        cube3.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
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
