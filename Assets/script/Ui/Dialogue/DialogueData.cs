using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Dialogue", menuName = "Dialogue/Advanced Dialogue")]
public class DialogueData : ScriptableObject
{
    [System.Serializable]
    public class DialogueLine
    {
        [TextArea(2, 5)]
        public string sentence;
        public string speakerName;
        public Sprite speakerImage;
    }

    public List<DialogueLine> lines = new List<DialogueLine>();
}