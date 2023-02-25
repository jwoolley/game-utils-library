using UnityEditor;
using UnityEngine;

// NOTE: Unity editor won't properly load this class if it exists in an
//       Editor folder, so instead it must live outside.
public class ReadOnlyAttribute : PropertyAttribute {

}

// NOTE: this property drawer can safely live in an Editor folder
// (unlike ReadOnlyAttribute), but let's keep it in the same file
// for the sake of simplicity.
[CustomPropertyDrawer(typeof(ReadOnlyAttribute))]
public class ReadOnlyDrawer : PropertyDrawer {
  public override float GetPropertyHeight(SerializedProperty property,
                                          GUIContent label) {
    return EditorGUI.GetPropertyHeight(property, label, true);
  }

  public override void OnGUI(Rect position,
                             SerializedProperty property,
                             GUIContent label) {
    GUI.enabled = false;
    EditorGUI.PropertyField(position, property, label, true);
    GUI.enabled = true;
  }
}