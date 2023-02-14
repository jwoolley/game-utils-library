using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaySoundButton : MonoBehaviour
{
  [SerializeField]
  private string AUDIO_SOURCE_NAME = "SFX_Potion_1";
  
  public void onClick() {
    playSound(AUDIO_SOURCE_NAME);
  }

  private void playSound(string key) {
    AudioSourceManager.getSfxSource(key).Play();
  }
}
