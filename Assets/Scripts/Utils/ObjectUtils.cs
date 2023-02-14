using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class ObjectUtils {
    public static Transform getChildWithName(GameObject parentObj, string name) {
        return getChildWithName(parentObj.transform, name);
    }

    public static Transform getChildWithName(Transform parent, string name) {
        return parent.Find(name);
    }

    public static List<GameObject> getChildren(GameObject parentObj) {
        return getChildren(parentObj.transform);
    }
    public static List<GameObject> getChildren(Transform parent) {
        List<GameObject> children = new List<GameObject>();

        foreach (Transform child in parent) {
            children.Add(child.gameObject);
        }

        return children;
    }

    public static string getTransformPath(Transform current) {
        if (current.parent == null) {
            return "/" + current.name;
        }
        return getTransformPath(current.parent) + "/" + current.name;
    }

    public static bool activateGameObject(GameObject gameObject) {
        if (gameObject != null) {
            gameObject.SetActive(true);
            foreach (Transform childTransform in gameObject.transform) {
                childTransform.gameObject.SetActive(true);
            }
            return true;
        }
        return false;
    }
    public static GameObject findPotentiallyInactiveGameObject(string path) {
        return Resources.FindObjectsOfTypeAll<GameObject>()
            .Select(gObj => gObj.transform)
            .FirstOrDefault(t => {
                if (t == null) {
                    return false;
                }
                String transformPath = getTransformPath(t);
                return t != null && getTransformPath(t).EndsWith(path);

            })
            .gameObject;
    }
}
