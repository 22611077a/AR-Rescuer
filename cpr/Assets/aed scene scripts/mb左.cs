using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class mb左 : MonoBehaviour
{
    public GameObject cube;
    public GameObject cube1;
    public GameObject cube2;
    public AudioSource soundPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseUpAsButton()
    {
        cube.SetActive(true);
        cube1.SetActive(false);
        cube2.SetActive(true);
        soundPlayer.Play();
    }
}
