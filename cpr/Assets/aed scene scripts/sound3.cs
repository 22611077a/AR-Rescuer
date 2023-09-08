using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class sound3 : MonoBehaviour
{
    public AudioSource soundPlayer;

    public VirtualButtonBehaviour vb;
    // Start is called before the first frame update

    void Start()
    {
        vb.RegisterOnButtonPressed(OnButtonPressed);
        vb.RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        soundPlayer.Play();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
