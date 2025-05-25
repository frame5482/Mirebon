using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DialogueData;
using UnityEngine.UI;

public class Textbase : MonoBehaviour
{ 
    
    [System.Serializable]
    public class DialogueData
    {
       
        public string speakerName;
        public Sprite speakerImage;

        [TextArea(2, 5)]
        public string ENGsentence;
        [TextArea(2, 5)]
        public string Thaisentence; 
        [TextArea(2, 5)]
        public string Jpsentence;
     

    }
    public Sprite Xeno;
    public Sprite REI;

    public List<DialogueData> TextData = new List<DialogueData>();


    public void Start()
    {
        TextData.Add(new DialogueData
        {
            speakerName = "frame",
            ENGsentence = "I don't know who you are... but the scent of blood lingers in your shadow.",
            Thaisentence = "ข้าไม่รู้ว่าเจ้าเป็นใคร... แต่เจ้ามีกลิ่นเลือดในเงา",
            Jpsentence = "青衣青衣",
          
            speakerImage = Xeno
        });
        TextData.Add(new DialogueData
        {
            speakerName = "dsadd",
            ENGsentence = "I don't know who you are... but the scent of blood lingers in your shadow.",
            Thaisentence = "ข้าไม่รู้ว่าเจ้าเป็นใคร... แต่เจ้ามีกลิ่นเลือดในเงา",
            Jpsentence = "青衣",

            speakerImage = Xeno
        }); 
        TextData.Add(new DialogueData
        {
            speakerName = "swww",
            ENGsentence = "I don't know who you are... but the scent of blood lingers in your shadow.",
            Thaisentence = "ข้าไม่รู้ว่าเจ้าเป็นใคร... แต่เจ้ามีกลิ่นเลือดในเงา",
            Jpsentence = "衣",

            speakerImage = Xeno
        });

    }
    public void Update()
    {
        
    }

}
