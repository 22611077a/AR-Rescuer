using System.Collections;
using System.Collections.Generic;
using Recognissimo.Components;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Recognissimo.Samples.VoiceControlExample
{
  [AddComponentMenu("")]
  public class VoiceCommander : MonoBehaviour
  {
    [SerializeField]
    private VoiceControl voiceControl;

    [SerializeField]
    public bool isClone;
    public string next,before,yes,no;
    public List<int> yesnoScene,nextScene,back2;



    private void Start()
    {
      if (!isClone) 
      {
        isClone = true;
        DontDestroyOnLoad(this);
      } 
      voiceControl.AsapMode = true;
      voiceControl.Commands.Add(new VoiceControlCommand(next, () => { Next(); }));
      voiceControl.Commands.Add(new VoiceControlCommand(before, () => { Before(); }));
      voiceControl.Commands.Add(new VoiceControlCommand(yes, () => { Yes(); }));
      voiceControl.Commands.Add(new VoiceControlCommand(no, () => { No(); }));
      voiceControl.StartProcessing();
    }
    public void Next()
    {
      if (!nextScene.Contains(SceneManager.GetActiveScene().buildIndex)) return;
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Before()
    {
      if (SceneManager.GetActiveScene().buildIndex -1 >= 1) 
      {
        if(back2.Contains(SceneManager.GetActiveScene().buildIndex)) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        else SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
      }
    }
    public void Yes()
    {
      if (!yesnoScene.Contains(SceneManager.GetActiveScene().buildIndex)) return;
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void No()
    {
      if (!yesnoScene.Contains(SceneManager.GetActiveScene().buildIndex)) return;
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
  }
}
