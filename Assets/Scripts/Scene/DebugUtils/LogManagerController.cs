using GameUtils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogManagerController : MonoBehaviour
{
    // Start is called before the first frame update
    CustomLogger exampleLogger;
    void Start() {
        exampleLogger = LogManager.getLogger(this.GetType());
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void exerciseExampleLogger() {
      exampleLogger.Log("Exercising logger.Log()");
      exampleLogger.LogWarning("Exercising logger.LogWarning()");
      exampleLogger.LogError("Exercising logger.LogError()");
  }
}
