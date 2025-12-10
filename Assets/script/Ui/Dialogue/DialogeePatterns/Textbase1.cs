using UnityEngine;
using System.Collections.Generic;


[CreateAssetMenu(fileName = "Textbase1", menuName = "Dialogue/Textbase")]
public class Textbase1 : ScriptableObject
{
    public List<TextLine> TextData = new List<TextLine>();
}
