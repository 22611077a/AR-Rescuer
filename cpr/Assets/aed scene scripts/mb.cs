using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class mb : MonoBehaviour
{
    public GameObject cube;
    void Start()
    {
        cube.SetActive(false);
    }
    private void OnMouseUpAsButton()
    {
        cube.SetActive(true);
    }
}
