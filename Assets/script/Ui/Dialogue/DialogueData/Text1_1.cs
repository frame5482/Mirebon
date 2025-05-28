using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DialogueData;
using UnityEngine.UI;

public class Text1_1 : MonoBehaviour
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
    public Sprite emty;
    public Sprite[] Xeno;
    public Sprite[] REI;
    public Sprite Smallemty;
    public Sprite[] SmallXeno;
    public Sprite[] SmallREI;
    public Sprite[] BGImage;
    public Sprite[] StoryImage;


    public Sprite[] Guardian;






    public List<DialogueData> TextData = new List<DialogueData>();


    public void Start()
    {
        TextData.Add(new DialogueData
        {
            speakerName = "REI",
            ENGsentence = " ….. It seems this city can no longer hold on",
            Thaisentence = " ….. ดูเหมือนเมืองนี้ จะไม่ไหวแล้ว",
            Jpsentence = "….. この街はもう持ちこたえられないようだ。",
          
            speakerImage = REI[0],
            SmallImage  = SmallREI[0],

            BGImage = BGImage[0], 
            StoryImage = StoryImage[0]
        });
        TextData.Add(new DialogueData
        {
            speakerName = "dsadd",
            ENGsentence = "Help!!!",
            Thaisentence = " ช่วยด้วยยยย!",
            Jpsentence = " 助けてくれ！",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]

        }); 
        TextData.Add(new DialogueData
        {
            speakerName = "swww",
            ENGsentence = "I don't know who you are... but the scent of blood lingers in your shadow.",
            Thaisentence = "ข้าไม่รู้ว่าเจ้าเป็นใคร... แต่เจ้ามีกลิ่นเลือดในเงา",
            Jpsentence = "衣",

            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[1]
        });

    }
    public void Update()
    {
        
    }

}
