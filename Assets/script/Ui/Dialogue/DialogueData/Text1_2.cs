using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DialogueData;
using UnityEngine.UI;

public class Text1_2 : Textbase
{ 
    
    public Sprite emty;
    public Sprite Smallemty;

    public Sprite[] Xeno;
    public Sprite[] SmallXeno;

    public Sprite[] REI;
    public Sprite[] SmallREI;

   
   
    
    public Sprite[] BGImage;
    public Sprite[] StoryImage;


  


    public void Start()
    {
        
      

        TextData.Add(new DialogueData
        {
            speakerName = "Narrator",

            Thaisentence = " ฉึก!",
            ENGsentence = " Clank!",
            Jpsentence = " カチッ！",

            speakerImage = emty,
            SmallImage = Smallemty,

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " แฮก! แฮก! ดูเหมือนจะหมดแล้วนะ",
            ENGsentence = " Huff! Huff!  It seems that's all?",
            Jpsentence = " はぁ……はぁ………もう限界か。",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " ที่นั้น\r\n",
            ENGsentence = " There",
            Jpsentence = " あそこだ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Narrator",

            Thaisentence = " เรย์หาอุโมงเจอ ",
            ENGsentence = " Rei found the tunnel.",
            Jpsentence = " レイがトンネルを見つけた。 ",

            speakerImage = emty,
            SmallImage = Smallemty,

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " แค่เข้าไปในอุโมงนี้ก็น่าจะหนีออกไปที่ด้านหลังเมืองได้สินะ\r\n ",
            ENGsentence = " If I just get inside this tunnel, I should be able to escape behind the city.\r\n ",
            Jpsentence = " このトンネルに入れば、街の裏側に逃げられるはずだ。\r\n ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " ……",
            ENGsentence = " ……",
            Jpsentence = " ……",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = "ไว้ใจได้เลยทุกคน เพื่อไม่ให้การเสียสละของพวกนายเสียเปล่า ผมจะไปกำจัด The End ลงให้ได้ ",
            ENGsentence = " Trust me everyone, to not let your sacrifice be in vain, I will defeat The End.\r\n ",
            Jpsentence = "みんな、信じてくれ。お前たちの犠牲を無駄にしないために、俺はThe Endを倒す ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Narrator",

            Thaisentence = " เรย์เดินเข้าไปในอุโมง ",
            ENGsentence = " Rei walked into the tunnel.",
            Jpsentence = " レイはトンネルの中へと歩みを進めた ",

            speakerImage = emty,
            SmallImage = Smallemty,

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " ตึก... ตึก...  ",
            ENGsentence = "Tap tap tap... ",
            Jpsentence = " タッタッタッ ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });
        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " ตึก... ตึก...ตึก... ตึก...  ",
            ENGsentence = "Tap tap tap tap tap... ",
            Jpsentence = " タッ タッ タッ タッ タッ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });
        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " ตึก... ตึก...ตึก... ตึก...ตึก... ตึก...  ",
            ENGsentence = "Tap tap tap tap taptap tap ... ",
            Jpsentence = " タッ タッ タッ タッ タッ タッ タッ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " เริ่มสังหรณ์ใจแปลกๆแล้วแหะ\r\n ",
            ENGsentence = " I’m starting to get a strange feeling. ",
            Jpsentence = " なんだか嫌な予感がしてきたな。 ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]

        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " นี่เป็นอุโมงสำหรับหนีออกหลังเมืองจริงๆหรือเปล่านะ\r\n ",
            ENGsentence = " Is this really the tunnel to escape behind the city?\r\n ",
            Jpsentence = " これは本当に街の裏に逃げるためのトンネルなのか？ ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Narrator",

            Thaisentence = " Rei เดินไปจนเจอประตูขนาดใหญ่ ",
            ENGsentence = " Rei walks until he finds a large door ",
            Jpsentence = " レイは大きな扉を見つけるまで歩く ",

            speakerImage = emty,
            SmallImage = Smallemty,

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });



        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " … กะแล้วเชียว ไม่ใช่อุโมงธรรมดาสินะ\r\n ",
            ENGsentence = " … I knew it. This isn’t an ordinary tunnel.\r\n ",
            Jpsentence = " ... やっぱりな、ただのトンネルじゃない。 ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });



        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " เจ้าเมืองนั่น ซ่อนอะไรไว้ใต้บ้านตัวเองกันนะ\r\n  ",
            ENGsentence = " What is that lord hiding beneath his own house?\r\n ",
            Jpsentence = " あの領主は自分の家の下に何を隠しているんだ？ ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Narrator",

            Thaisentence = "Phantom ปรากฏตัวออกมา ",
            ENGsentence = " Phantom appear ",
            Jpsentence = " ファントム現れた ",

            speakerImage = emty,
            SmallImage = Smallemty,

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " เรื่องนั้นเอาไว้ก่อนละกัน ก่อนอื่นต้องจัดการเจ้าพวกนี้ก่อนสินะ ",
            ENGsentence = " but that for later. First, I have to deal with these guys.\r\n ",
            Jpsentence = " それは後回しにしよう。まずはこいつらを片付けなきゃな。\r\n ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });
      


    }



}
