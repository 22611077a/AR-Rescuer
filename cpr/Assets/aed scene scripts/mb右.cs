using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class mb¥k : MonoBehaviour
{
    public GameObject cube;
    public GameObject cube1;
    void Start()
    {
        
    }
    private void OnMouseUpAsButton()
    {
        cube.SetActive(true);
        cube1.SetActive(true);
    }
}
