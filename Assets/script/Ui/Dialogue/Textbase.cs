using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DialogueData;
using UnityEngine.UI;
using System;

public class Textbase : MonoBehaviour
{ 
    
    [System.Serializable]
    public class DialogueData
    {
       
        public string speakerName;
        public Sprite speakerImage;
        public Sprite SmallImage;

        public Sprite BGImage;
        public Sprite StoryImage;



        [TextArea(2, 5)]
        public string ENGsentence;
        [TextArea(2, 5)]
        public string Thaisentence; 
        [TextArea(2, 5)]
        public string Jpsentence;
     

    }
 

    public List<DialogueData> TextData = new List<DialogueData>();


  
}
