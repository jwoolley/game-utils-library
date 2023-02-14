using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintDebugLog : MonoBehaviour
{
    [SerializeField]
    string debugMessage = "De bug is a-loggin' to-night!";
    public void onClick() {
      printDebugLog(debugMessage);
    }

    private void printDebugLog(string msg) {
      Debug.Log(msg);
    }
}
