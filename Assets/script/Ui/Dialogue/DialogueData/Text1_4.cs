using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DialogueData;
using UnityEngine.UI;

public class Text1_4 : Textbase
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

    {    TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " จะเริ่มอธิบายตั้งแต่ตรงไหนดีละเนี่ย ก่อนอื่นคงรู้จัก Phantom ใช่ไหม\r\n ",
            ENGsentence = " Where should I start explaining? You know about Phantoms, right? ",
            Jpsentence = "  さて、どこから説明しようかな。まず、Phantomは知ってるよな？ ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",

            Thaisentence = " แน่นอน ก็พวกผีสาง ปีศาจทั้งหลายใช่ไหมละ\r\n ",
            ENGsentence = " Of course, those ghosts and Phantom  and such, right?\r\n",
            Jpsentence = " もちろん、あの幽霊とか悪魔みたいなやつだろ？ ",

            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " ใช่แล้วล่ะ แต่ว่า Phantom จะแตกต่างกับปีศาจทั่วไปนิดหน่อยนะ Phantom \r\n น่ะคือสิ่งมีชีวิตที่ถูก MirEbon กลืนกลินจนกลายเป็นสภาพแบบนั้นไงละ\r\n ",
            ENGsentence = " Exactly. But Phantoms are a bit different from normal Phantom .\r\n  They are creatures swallowed by MirEbon and transformed like that.\r\n ",
            Jpsentence = " そうだ。でもファントムは普通の悪魔とはちょっと違う。MirEbonに飲み込まれてああなった生き物なんだ。\r\n ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",

            Thaisentence = " อย่างงี้นี้เองถ้าอย่างงั้น แสดงว่าเมืองนี้กำลังถูก MirEbon อะไรนั่นกลืนกินสินะ\r\n แล้ว MirEbon มันหน้าตาเป็นยังไงละ ",
            ENGsentence = " I see. So this town is being swallowed by that MirEbon thing?\r\n What does MirEbon look like?\r\n ",
            Jpsentence = " なるほど。じゃあこの街はMirEbonに飲み込まれているってことか？\r\nMirEbonってどんな姿なんだ？",

            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " ถูกต้องเข้าใจอะไรไวดีนะ MirEbon คือชื่อเรียกของโคลนทมิฬที่ปรากฏตัวขึ้นมาเมื่อ 1000 ปีก่อน\r\n มันค่อยๆกลืนกินทุกสิ่งอย่างบนโลก แล้วครั้งนี้ก็ถึงตาของเมืองนี้แล้วยังไงละ\r\n",
            ENGsentence = " Exactly, you’re quick to understand. MirEbon is the name of a black sludge that appeared 1000 years ago.\r\n It slowly devours everything on Earth, and now it’s this town’s turn.\r\n ",
            Jpsentence = " その通り、理解が早いな。MirEbonは1000年前に現れた黒い泥のようなもので、\r\n 世界の全てをゆっくりと飲み込んでいる。そして今、この街がその番だ。 ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",

            Thaisentence = " แล้วทำอะไรกับมันไม่ได้เลยรึไง\r\n ",
            ENGsentence = " So there’s nothing you can do about it?\r\n ",
            Jpsentence = " それに対して何もできないのか？\r\n ",

            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " ถ้าเป็นปกติผมสามารถชำระล้างมันได้อยู่หรอก แต่ครั้งนี้เป็นคลื่นใหญ่ของ MirEbon คงชำระล้างได้ไม่หมด\r\n แถม MirEbon ยังมาพร้อมกับ Phantom จำนวนมหาศาลอีกด้วย ",
            ENGsentence = " Normally I can purify it, but this time it’s a huge wave of MirEbon,\r\n so I can’t cleanse it all. Plus, MirEbon brings a massive number of Phantoms with it.\r\n ",
            Jpsentence = " 普段なら浄化できるんだが、今回はMirEbonの大波が来てて全部は浄化できそうにない。\r\n それにファントムも大量に連れてきている。 ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",

            Thaisentence = " อย่างงี้นี่เอง ",
            ENGsentence = " I see.",
            Jpsentence = " そうか。",

            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " …. แต่ก็ไม่ใช่ว่าไร้หนทางซะทีเดียวนะ ณ ปลายสุดขอบโลกว่ากันว่ามีสิ่งมีชีวิตลึกลับ The End อยู่ที่นั่น และตามตำนานก็ว่าไว้ \r\nMirEbon นั้นเกิดมาจาก The End หากกำจัดมันได้ MirEbon ก็อาจหายไปก็ได้\r\n ",
            ENGsentence = " …But it’s not completely hopeless. At the edge of the world,\r\n there’s said to be a mysterious lifeform called The End. Legend says MirEbon was born from The End, so if you destroy it, MirEbon might disappear.\r\n ",
            Jpsentence = " …だが、完全に絶望的というわけでもない。世界の果てにはThe Endという謎の生物がいると言われている。\r\n 伝説ではMirEbonはThe Endから生まれたので、倒せばMirEbonも消えるかもしれない。\r\n ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " ก็แค่เรื่องเล่าไร้สาระไม่ใช่รึ มีหลักฐานอะไรหรือไงว่ามันมีอยู่จริง ถึงต่อให้มีอยู่จริง\r\n การกำจัดมันเราก็ไม่คิดว่ามันจะทำให้ MirEbon หายไปหรอกนะ ",
            ENGsentence = " Isn’t that just nonsense stories? Any proof it exists? Even if it does,\r\n I don’t think killing it would make MirEbon go away. ",
            Jpsentence = " それはただの作り話だろ？証拠でもあるのか？仮に存在しても倒したところでMirEbonが消えるとは思えない。  ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " ฮ่า ฮ่า ก็จริงอย่างทีเธอว่านะ….มันก็แค่เรื่องเล่าไร้สาระนั่นเหละ\r\n ",
            ENGsentence = " Haha, you’re right... it’s just a fairy tale.\r\n ",
            Jpsentence = " はは、確かにな…ただの作り話だ。 ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " ตอนแรกผมก็ไม่เชื่อหรอกเรื่องแบบนั้นน่ะ ผมก็เลยเลือกที่จะอาศัยอยู่ที่เมืองนี้และเป็น Guardian\r\n คอยปกป้องเมืองแทนการไปตามล่า The End ยังไงล่ะ ",
            ENGsentence = "  At first, I didn’t believe in those stories either.\r\n So I chose to live in this town and be a Guardian, protecting it instead of hunting The End.\r\n ",
            Jpsentence = " 最初は俺も信じてなかった。だからこの街に住んでガーディアンとして守ることにしたんだ。\r\nThe Endを追いかける代わりに ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " แต่ว่าพอเรื่องมันเป็นแบบนี้แล้ว ถึงจะเป็นเรื่องเล่าไร้สาระก็เถอะแต่ลองเชื่อมันสักหน่อยก็ไม่เสียหายอะไรนี่หนา ",
            ENGsentence = " But now, even if it’s nonsense stories, believing it a little won’t hurt.\r\n ",
            Jpsentence = " だが、こうなった今となっては、たとえ作り話でも少しは信じてみても悪くない。\r\n  ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " ยังไงก็ไม่มีอย่างอื่นที่ทำได้แล้วนี่นะ ฮ่า ฮ่า\r\n",
            ENGsentence = "  There’s nothing else we can do anyway. Haha.\r\n ",
            Jpsentence = "  他にできることもないしな。はは。\r\n  ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",

            Thaisentence = " ….. ถ้างั้นจากนี้นายก็จะไปตามล่า The End อะไรนั่นสินะ\r\n ",
            ENGsentence = " …So from now on, you’re going to hunt The End, huh?\r\n ",
            Jpsentence = " …じゃあこれからThe Endを追いかけるんだな？\r\n",

            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });
        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " ใช่แล้วละ\r\n ",
            ENGsentence = " That’s right.\r\n",
            Jpsentence = " そうだ。\r\n  ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",

            Thaisentence = " งั้นเราจะไปด้วยก็แล้วกัน\r\n ",
            ENGsentence = "Then I’ll go with you.\r\n ",
            Jpsentence = " じゃ－われも行く。 ",

            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " เอ๊ะ จริงหรอ มันค่อนข้างอันตรายมากเลยนะ ",
            ENGsentence = " Eh, really? It’s pretty dangerous, you know.",
            Jpsentence = " え、本当か？かなり危険だぞ。  ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",

            Thaisentence = " แน่นอนสิ ยังไงก็ไม่มีที่จะไปอยู่แล้วด้วย ลองไปผู้กล้ากอบกู้โลกบ้างก็ไม่เลวเหมือนกัน ",
            ENGsentence = " Of course. I have nowhere else to go anyway. Being a hero who saves the world isn’t bad either. ",
            Jpsentence = " もちろんだ。どこにも行くところもないし、世界を救う勇者になるのも悪くない。\r\n ",

            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " ฮ่า ฮ๋า ถ้างั้นก็ช่วยได้มาเลย ดูจากทีสู้เมื่อกี้แล้วเธอเองก็แข็งแกร่งมาด้วยสิ หวังพึ่งอยู่นะ\r\n ",
            ENGsentence = " Haha, then you’re welcome to help. From how you fought earlier, you’re strong. I’ll be counting on you.\r\n ",
            Jpsentence = " はは、なら手伝ってくれ。さっきの戦い方を見ると、強そうだし期待してるぞ。\r\n ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });
        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " ทางนั้นน่าจะมีทางไปต่ออยู่ ไปกันเถอะ\r\n ",
            ENGsentence = " There should be a way forward there. Let’s go.\r\n ",
            Jpsentence = "  あっちに先へ進む道があるはずだ。行こう。\r\n ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });



        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " ",
            ENGsentence = " ",
            Jpsentence = "  ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",

            Thaisentence = " ",
            ENGsentence = " ",
            Jpsentence = " ",

            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


    }



}
