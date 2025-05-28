using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DialogueData;
using UnityEngine.UI;

public class Text1_1 : Textbase
{ 
    
    public Sprite emty;
    public Sprite Smallemty;

    public Sprite[] Xeno;
    public Sprite[] SmallXeno;

    public Sprite[] REI;
    public Sprite[] SmallREI;

   
   
    
    public Sprite[] BGImage;
    public Sprite[] StoryImage;


    public Sprite[] Guardian;
    public Sprite[] smallGuardian;


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
            speakerName = "villagers 1",
            ENGsentence = "Help!!!",
            Thaisentence = "ช่วยด้วยยยย!",
            Jpsentence = "助けてくれ！",

            speakerImage = emty,
            SmallImage = Smallemty,

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]

        }); 
        TextData.Add(new DialogueData
        {
            speakerName = "villagers 2",
            ENGsentence = "Anyone!",
            Thaisentence = "ใครก็ได้!",
            Jpsentence = " 誰か！",

            speakerImage = emty,
            SmallImage = Smallemty,

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "REI",

            Thaisentence = " ..... ขอโทษ…ที่ช่วยทุกคนไม่ได้",
            ENGsentence = " .....Sorry… I couldn’t save everyone.",
            Jpsentence = " ....ごめん…みんなを助けられなくて。",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Guardian 1",

            Thaisentence = "  หัวหน้า..รีบหนีไปเถอะครับ",
            ENGsentence = "  Captain… you need to run away quickly.",
            Jpsentence = " ....ごめん…みんなを助けられなくて。",

            speakerImage = Guardian[0],
            SmallImage = smallGuardian[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]




        });

        TextData.Add(new DialogueData
        {
            speakerName = "REI",

            Thaisentence = " ...ทำแบบนั้นไม่ได้หรอก อย่างน้อยๆผมเองก็จะขอสู้ไปกับทุกคนด้วย ",
            ENGsentence = " ... I can’t do that. At least, I’ll fight alongside everyone.",
            Jpsentence = " …そんなことはできない。せめてみんなと一緒に戦う。 ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Guardian 2",

            Thaisentence = "หัวหน้า อย่าพูดแบบนั้นสิคะ ขอแค่คุณรอดไปได้ พวกเราเองก็ยังมีความหวังอยู่.. ",
            ENGsentence = "Captain, please don’t say like that…if you are still alive, there’s still hope for all of us… ",
            Jpsentence = "隊長、そんなこと言わないで。あなたが生き残れば、私たちにもまだ希望がある ",

            speakerImage = Guardian[1],
            SmallImage = smallGuardian[1],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "REI",

            Thaisentence = "…… ",
            ENGsentence = "…… ",
            Jpsentence = "…… ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "REI",

            Thaisentence = "……แต่ว่า ",
            ENGsentence = "…… But",
            Jpsentence = "……でも ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Guardian 1",

            Thaisentence = " หัวหน้า!",
            ENGsentence = " Captain!",
            Jpsentence = " 隊長！ ",

            speakerImage = Guardian[0],
            SmallImage = smallGuardian[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Guardian 2",

            Thaisentence = " หัวหน้าคะ โคลนทมิฬได้ปกคลุมเมืองนี้ไว้แล้ว ปีศาจที่มากับมันก็โผล่ออกมาไม่หยุดไม่หย่อน ในตอนที่พวกเรายังต้านไหวอยู่ ได้โปรด..\r\n",
            ENGsentence = " Captain, the black mud has covered the city. The Phantom  that comes with it keeps emerging without stop. While we can still resist, please...",
            Jpsentence =  " 隊長、この黒い泥が街を覆い、そこから出てくるファントムが止まらない。まだ抵抗できるうちに、お願い…",

            speakerImage = Guardian[1],
            SmallImage = smallGuardian[1],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "REI",

            Thaisentence = "…… ",
            ENGsentence = "…… ",
            Jpsentence = "…… ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "REI",

            Thaisentence = " เข้าใจแล้ว…\r\n ",
            ENGsentence = " I understand…\r\n ",
            Jpsentence = " 分かった…\r\n ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });
        TextData.Add(new DialogueData
        {
            speakerName = "Guardian 2",

            Thaisentence = " แย่แล้ว พวกปีศาจมาถึงที่นี่แล้ว หัวหน้าคะ รีบไปเถอะคะ\r\n",
            ENGsentence = " shit! The Phantom  has reached here. Captain, please go.\r\n",
            Jpsentence = "  やばい、ファントムがここまで来た。隊長、急いで逃げてください。",

            speakerImage = Guardian[1],
            SmallImage = smallGuardian[1],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Guardian 1",

            Thaisentence = " หัวหน้า ไปที่บ้านของท่านเจ้าเมือง ที่ห้องเก็บของเก่าน่าจะมีอุโมงสำหรับหลบหนีอยู่\r\n",
            ENGsentence = " Captain, Head to the mayor’s house! There should be an old storage \r\n room—there’s an escape tunnel hidden there!",
            Jpsentence = " 隊長、領主の家に行け。古い倉庫の部屋に逃げ道のトンネルがあるはずだ。 ",

            speakerImage = Guardian[0],
            SmallImage = smallGuardian[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });




        TextData.Add(new DialogueData
        {
            speakerName = "REI",

            Thaisentence = " นายรู้เรื่องแบบนั้นได้ยังไงกัน ",
            ENGsentence = " How do you know about that?\r\n ",
            Jpsentence = " そんなこと、どうして知ってるんだ？\r\n ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });
        TextData.Add(new DialogueData
        {
            speakerName = "Guardian 1",

            Thaisentence = " เรื่องแบบนั้นช่างมันเถอะ….หัวหน้า….ที่เหลือฝากด้วยละ",
            ENGsentence = " That doesn’t matter right now…Captain… I’m leaving the rest to you",
            Jpsentence = " そんなことはいい…隊長…あとは頼んだ。 ",

            speakerImage = Guardian[0],
            SmallImage = smallGuardian[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "REI",

            Thaisentence = "..อ่า ไว้ใจได้เลย ",
            ENGsentence = "…You can leave it to me.\r\n ",
            Jpsentence = "..ぼくに任せて ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });



        TextData.Add(new DialogueData
        {
            speakerName = "Narrator",

            Thaisentence = "เรย์วิ่งหนีออกมา\r\n",
            ENGsentence = "Rei has run away",
            Jpsentence = " レイは逃げた\r\n",

            speakerImage = emty,
            SmallImage = Smallemty,

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });



        TextData.Add(new DialogueData
        {
            speakerName = "REI",

            Thaisentence = " ..ที่นี่เองก็ยังมีอยู่อีกหรอ Phantom… ",
            ENGsentence = " So, even here, the Phantom…\r\n ",
            Jpsentence = " ここにもまだいるのか、ファントム ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "REI",

            Thaisentence = " เอาเถอะ…ดาหน้าเข้ามาเลย เจ้าพวกปีศาจ!!\r\n",
            ENGsentence = " Fine… come at me, Phantom !!",
            Jpsentence = " いいだろう…かかってこい、悪魔 ！！",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });



    }


    
}
