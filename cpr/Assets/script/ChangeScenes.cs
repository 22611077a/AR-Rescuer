using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    public void home()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
    public void scene1_2next()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(11);
    }
    public void scene1_2back()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
    public void scene2next()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(12);
    }
    public void scene2back()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(11);
    }
    public void scene3Y()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(13);
    }
    public void scene3N()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(14);
    }
    public void scene3back()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(11);
    }
    public void scene4()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(12);
    }
    public void scene5next()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(15);
    }
    public void scene5back()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(12);
    }
    public void scene6Y()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(16);
    }
    public void scene6N()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(17);
    }
    public void scene6back()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(14);
    }
    public void scene7()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(15);
    }

    public void scene8next()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(18);
    }
    public void scene8back()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(15);
    }
    public void scene9back()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(17);
    }
    public void Tempo()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(19);
    }
    public void Music()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=mfWp3c-MpVU&ab_channel=tirochannal");
    }
    public void map()
    {
        Application.OpenURL("http://www.aedmap.com.tw/menu6/aedmap.html");
    }
    public void AED()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(20);
    }
}