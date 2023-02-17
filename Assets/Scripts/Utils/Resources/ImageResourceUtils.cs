using System;
using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

public static class ImageResourceUtils {
  static IEnumerator Texture2dRequest(string localPath, Action<UnityWebRequest> callback) {
    using (UnityWebRequest request = UnityWebRequestTexture.GetTexture($"file://{localPath}")) {
      yield return request.SendWebRequest();
      callback(request);
    }
  }

  static public void DownloadImage(MonoBehaviour mono, string localPath, Action<Texture2D> callback) {
    mono.StartCoroutine(Texture2dRequest(localPath, (UnityWebRequest request) => {
      if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError) {
        logWarning($"{request.error}: {request.downloadHandler.text}");
      } else {
        Texture2D texture = DownloadHandlerTexture.GetContent(request);
        log($"Succesfully downloaded texture: {texture}");
        callback(texture);
      }
    }));
  }

  // TODO: attach logger for resource/system etc. errors.
  private static void log(String msg) {
    Debug.Log(msg);
  }
  private static void logWarning(String msg) {
    Debug.LogWarning(msg);
  }
}