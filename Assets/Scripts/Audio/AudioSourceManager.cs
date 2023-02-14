using System;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceManager : MonoBehaviour {

    private const string PLACEHOLDER_SFX_OBJECT_NAME = "SFX_SourceNotFoundPlaceholder";

    private enum AudioSourceCategory {
        SFX,
        MUSIC
    }

    private static Dictionary<string, AudioSource> nameToSourceMap = new Dictionary<string, AudioSource>();
    private static bool _isPlaceholderInitialized = false;

  // TODO: track failed-to-load sources so they can be made visible / reported on
  private static AudioSource findAudioSource(AudioSourceCategory category, string objectName) {
        string categorySubPath = category == AudioSourceCategory.SFX ? "Sfx" : "Music";
        GameObject gameObject = GameObject.Find("StaticAssets/Audio/" + categorySubPath + "/" + objectName);
        AudioSource audioSource = null;
        if (gameObject != null) {
            audioSource = gameObject.GetComponent<AudioSource>();
        }
        return audioSource;
    }

  public static AudioSource getPlaceholderSound() {
    AudioSource audioSource = null;
    if (!_isPlaceholderInitialized) {
      _isPlaceholderInitialized = true;
      audioSource = getSfxSource(PLACEHOLDER_SFX_OBJECT_NAME);
    }
    return audioSource;
  }

    public static AudioSource getSfxSource(string objectName) {
        AudioSource audioSource = null;

        if (!nameToSourceMap.ContainsKey(objectName)) {
            audioSource = findAudioSource(AudioSourceCategory.SFX, objectName);
            if (audioSource == null) {
              Debug.LogWarning("AudioSourceManager::getSfxSource failed to load SFX with name " + objectName);
              audioSource = getPlaceholderSound();
            }
            if (audioSource != null) {
                nameToSourceMap.Add(objectName, audioSource);
            }
        } else {
            audioSource = nameToSourceMap[objectName];
        }

        return audioSource;
    }
}