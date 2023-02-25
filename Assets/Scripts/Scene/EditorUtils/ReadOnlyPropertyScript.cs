using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadOnlyPropertyScript : MonoBehaviour
{
  [ReadOnly, SerializeField]
  private float ReadOnlyFloat = 7.25f;

  [ReadOnly, SerializeField]
  private string ReadOnlyString = "Using the 'ReadOnly' attribute.  ";


  [ReadOnly, SerializeField, TextArea(2, 2)]
  private string ReadOnlyTextArea = "Also using the 'ReadOnly' attribute.";

  [ReadOnly, SerializeField, TextArea(8, 8)]
  private string ReadOnlyAttributeNotes = "This behavior is enabled by the 'ReadOnlyAttribute' in this project."
    + "\n\nNote that read-only fields won't update in the editor when their values change."
    + " To work around this, change the name of the field and save (and then change it back).";
}
