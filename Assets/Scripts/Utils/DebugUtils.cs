using UnityEngine;

public static class DebugUtils {
    private const bool IS_DEBUG_MODE_IN_EDITOR = true;
    public static bool isDebugBuild {
        get { return Debug.isDebugBuild || IS_DEBUG_MODE_IN_EDITOR && Application.isEditor; }
    }
}