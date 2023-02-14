using UnityEngine;

namespace Assets.Scripts.Utils {
  public class EditorDebugControl : MonoBehaviour {
    [SerializeField]
    bool enableDebugLoggingInEditor = true;

    const bool enableDebugLoggingInBuild = false;
    public void Awake() {
      // TODO: consider making configurable per log level using filterLogType
      //       https://docs.unity3d.com/ScriptReference/Logger-filterLogType.html
# if UNITY_EDITOR
      Debug.unityLogger.logEnabled = enableDebugLoggingInEditor;
#else
      Debug.unityLogger.logEnabled = enableDebugLoggingInBuild;
#endif
    }

    // this is called when the component is changed 
    // (e.g. the enableDebugLogging checkbox is toggled)
    public void OnValidate() {
      Debug.unityLogger.logEnabled = enableDebugLoggingInEditor;
    }
  }
}