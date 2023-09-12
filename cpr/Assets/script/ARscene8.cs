using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ARscene8 : MonoBehaviour
{
    public double time;
    public double ctime;
    public double btime;
    private bool videoplay = true;
    public VideoPlayer Video;
    public GameObject cube;
    public VideoPlayer tempo;
    public GameObject cubetempo;
    public GameObject panel2;
    private void Awake()
    {
        time = Video.GetComponent<VideoPlayer>().clip.length;
    }

    // Update is called once per frame
    void Update()
    {
        if (cube.gameObject.activeSelf == true)
        {
            ctime += Time.deltaTime;
            if (ctime >= 20)
            {
                cubetempo.SetActive(true);
                tempo.Play();
            }
            if (ctime >= 32)
            {
                cube.SetActive(false);
                panel2.SetActive(true);
            }
        }
        if (cubetempo.gameObject.activeSelf == true)
        {
            btime += Time.deltaTime;
            if (btime >= time)
            {
                videoplay = false;
            }
        }

        if (videoplay == false)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(14);
        }
    }
}