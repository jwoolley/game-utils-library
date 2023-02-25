using UnityEngine;

public class ScriptableObjectNotes : MonoBehaviour {


  [ReadOnly, SerializeField, TextArea(12,12)]
  private string HowToUse = "To create a Unity asset from a ScriptableObject script:"
  + "\n\n• Define a class that extends ScriptableObject (e.g. the included ExampleScriptableObject)."
  + "\n\n• In Unity editor, right click the script & choose 'Create Asset from ScriptableObject'."
  + "\n\nA new asset will be created from the script, which then can be assocated with MonoBehaviours, etc..";

  [ReadOnly, SerializeField, TextArea(2,2)]
  private string ThisMenuOptionIsEnabledBy = "The 'CreateScriptableObject' editor script.";

}
