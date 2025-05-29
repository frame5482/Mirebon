using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DialogueData;
using UnityEngine.UI;

public class Text1_3 : Textbase
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
            speakerName = "Rei",

            Thaisentence = "เอาละ จะมีอะไรอยู่ข้างในกันนะ",
            ENGsentence = "Alright, I wonder what’s inside.",
            Jpsentence = "さて、中には何があるのだろうか。",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Narrator",

            Thaisentence = "เรย์เปิดประตู",
            ENGsentence = "Rei opens the door",
            Jpsentence = "レイが扉を開ける",

            speakerImage = emty,
            SmallImage = Smallemty,

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Narrator",

            Thaisentence = "เรย์เข้าไปพบกับหญิงสาวถูกขังอยู่ในคริสตัล",
            ENGsentence = "Rei came upon a young woman trapped inside a crystal.",
            Jpsentence = "レイはクリスタルに閉じ込められた少女と出会った。",

            speakerImage = emty,
            SmallImage = Smallemty,

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = "เด็กสาว? …ไม่…..จากลางสังหรณ์ของผมแล้ว ดูไม่น่าใช่แค่เด็กสาวธรรมดาๆแฮะ",
            ENGsentence = "A girl? …No…...From my premonition, she doesn’t seem to be just an ordinary girl.",
            Jpsentence = "少女か？……いいえ......予感だが、ただの普通の少女ではなさそうだ。",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],
            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Narrator",
            Thaisentence = "แคล้ง!",
            ENGsentence = "Clang!",
            Jpsentence = "ガシャーン！",

            speakerImage = emty,
            SmallImage = Smallemty,

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Narrator",

            Thaisentence = "คริสตัลแตก",
            ENGsentence = "Crystal shatters",
            Jpsentence = "クリスタルが砕ける",

            speakerImage = emty,
            SmallImage = Smallemty,

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

      

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",
            Thaisentence = "?!?!",
            ENGsentence = "?!?!",
            Jpsentence = "！？！？",
            speakerImage = REI[0],
            SmallImage = SmallREI[0],
            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",
            Thaisentence = "ดูเหมือนอยู่ๆคริสตัลก็แตกออกมาเองซะแล้วแฮะ",
            ENGsentence = "Looks like the crystal just suddenly broke on its own.",
            Jpsentence = "どうやらクリスタルが勝手に割れたようだな。",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],
            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });
        TextData.Add(new DialogueData
        {
            speakerName = "Narrator",
            Thaisentence = "Rei เดินเข้าไปดูหญิงสาว",
            ENGsentence = "Rei approaches the girl",
            Jpsentence = "レイが少女に近づく",

            speakerImage = emty,
            SmallImage = Smallemty,

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = "เป็นอะไรรึป่าว มะกี้ตกลงมาแรงน่าดูเลยนะ",
            ENGsentence = "Are you okay? You fell pretty hard just now.",
            Jpsentence = "大丈夫か？さっきかなり強く落ちたみたいだが。",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],
            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "???",

            Thaisentence = "....",
            ENGsentence = "....",
            Jpsentence = "....",

            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],
            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = "อ่อ…",
            ENGsentence = "Oh…",
            Jpsentence = "ああ……",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],
            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "???",

            Thaisentence = "....",
            ENGsentence = "....",
            Jpsentence = "....",

            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],
            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",
            Thaisentence = "คือ…",
            ENGsentence = "Um…",
            Jpsentence = "あの……",
            speakerImage = REI[0],
            SmallImage = SmallREI[0],
            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "???",

            Thaisentence = ".....",
            ENGsentence = ".....",
            Jpsentence = ".....",

            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],
            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = "ช่วยพูดอะไรหน่อยได้ไหม ฟังที่ฉันพูดรู้เรื่องรึเปล่า?",
            ENGsentence = "Can you say something? Do you understand what I’m saying?",
            Jpsentence = "何か話せるか？俺の言ってることが分かるかな？",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],
            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "???",

            Thaisentence = "หนวกหู! คนพึ่งจะตื่นแท้ๆ อย่ามารบกวนสิ",
            ENGsentence = "Annoying! I just woke up, don’t bother me.",
            Jpsentence = "うるさい！今起きたばかりだ、邪魔しないでくれ。",

            speakerImage = Xeno[1],
            SmallImage = SmallXeno[0],
            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "???",

            Thaisentence = "เอาเถอะ เจ้าเป็นใครน่ะ",
            ENGsentence = "Whatever, who are you anyway?",
            Jpsentence = "まあいい、あんたは誰だ？",

            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],
            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = "ผม “มลทินนิรันดร์ เรย์” หัวหน้าหน่วยการ์เดี้ยนของเมืองนี้น่ะ แล้วเธอละ",
            ENGsentence = "I’m “Eternal Blight Rei,” the Guardian Captain of this city. And you?",
            Jpsentence = "俺は「永久の汚れ」レイ、この街のガーディアン隊長だ。あんたは？",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],
            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",

            Thaisentence = "เราคือ เซโน่..",
            ENGsentence = "I am Xeno...",
            Jpsentence = "われセノ……",

            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],
            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = ".....",
            ENGsentence = ".....",
            Jpsentence = "……",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],
            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",

            Thaisentence = "……",
            ENGsentence = "……",
            Jpsentence = "……",

            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],
            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",

            Thaisentence = "เทพศาสตรา เซโน่….. จำเป็นต้องบอกนามที่สองด้วยรึไง?",
            ENGsentence = "Xeno the Sacred Armament... Do I really have to give my second name?",
            Jpsentence = "神器セノ……称号まで言う必要あるのか？",
            speakerImage = Xeno[3],

            SmallImage = SmallXeno[0],
            BGImage = BGImage[0],
            StoryImage = StoryImage[0]

        });


        TextData.Add(new DialogueData
        {
            speakerName = "Rei",
            Thaisentence = "ก็จะได้รู้จักกันมากขึ้นไง ว่าแต่เทพศาสตรางั้นหรอ….",
            ENGsentence = "that we can know each other better. By the way, Sacred Armament huh…",
            Jpsentence = "もっと知り合いになるためだよ。ところで神器ってか……",
            speakerImage = REI[0],
            SmallImage = SmallREI[0],
            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",
            Thaisentence = "แสดงว่าเธอใช้อาวุธได้เก่งมากๆเลยสินะ",
            ENGsentence = "That means you’re really skilled with weapons.",
            Jpsentence = "武器の使い手としてかなりの腕前ってことか。",
            speakerImage = REI[0],
            SmallImage = SmallREI[0],
            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",
            Thaisentence = "จะว่าไงดี เห็นเด็กสาวตัวเล็กแค่นี้มีฉายาเทพศาสตราแล้วรู้สึกแปลกๆแฮะ",
            ENGsentence = "How should I say, seeing such a small girl with the title Divine Weapon feels a bit strange.",
            Jpsentence = "なんていうか、小さな少女が神器の称号を持ってるのはちょっと変な感じだな。",
            speakerImage = REI[0],
            SmallImage = SmallREI[0],
            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",

            Thaisentence = "ทางนั้นต่างหาก “มลทินนิรันดร์” ดูยังไงก็เป็นชื่อที่ไม่เข้ากับรูปลักษณ์ภายนอกของเจ้าเลยนะ",
            ENGsentence = "I give that back to you back, “Eternal Blight,” no matter how I see it, that name doesn’t suit your appearance at all.",
            Jpsentence = "そっちこそ、「永久の汚れ」ってのは見た目と全然合ってない名前だな。",

            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",
            Thaisentence = "ฮ่าๆ ก็มีคนบอกแบบนั้นบ่อยอยู่",
            ENGsentence = "Haha, I get told that a lot.",
            Jpsentence = "はは、よくそう言われるよ。",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",
            Thaisentence = "เอาเถอะ ช่วยไม่ได้นี่นา ชื่อนี้ก็เป็นเหมือนตราบาปของผมนั้นเหละ ผมน่ะ–",
            ENGsentence = "Whatever, it can’t be helped. This name is like a stain I carry. I–",
            Jpsentence = "まあ仕方ないよ。この名前は俺の呪いみたいなもんだからな、俺は――",
            speakerImage = REI[0],
            SmallImage = SmallREI[0],
            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",
            Thaisentence = "หยุดเลย! เราไม่อยากจะรับฟังเศร้าๆ อะไรของเจ้าหรอกนะ บอกตามตรงว่าน่ารำคาญ",
            ENGsentence = "Stop! I don’t want to hear your sad stories. Honestly, it’s annoying.",
            Jpsentence = "やめろ！お前の暗い話なんて聞きたくない。正直うざい。",
            speakerImage = Xeno[1],
            SmallImage = SmallXeno[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",
            Thaisentence = "ฮ่าๆ ขอโทษที ไม่ได้ตั้งใจจะดึงดราม่าอะไรสักหน่อย",
            ENGsentence = "Haha, sorry. I didn’t mean to bring any drama.",
            Jpsentence = "はは、ごめん、ドラマを作ろうとしたわけじゃないんだ。",
            speakerImage = REI[0],
            SmallImage = SmallREI[0],
            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",
            Thaisentence = "แล้วทำไมเธอถึงมาอยู่ที่นี่ได้ละ",
            ENGsentence = "So why are you here?",
            Jpsentence = "で、なんでここにいるんだ？",
            speakerImage = REI[0],
            SmallImage = SmallREI[0],
            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",
            Thaisentence = "เราเองก็อยากรู้เหมือนกัน",
            ENGsentence = "I want to know that too.",
            Jpsentence = "私も知りたいところだ。",
            speakerImage = Xeno[3],
            SmallImage = SmallXeno[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",
            Thaisentence = "......",
            ENGsentence = "......",
            Jpsentence = "……",
            speakerImage = REI[0],
            SmallImage = SmallREI[0],
            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",
            Thaisentence = "…..",
            ENGsentence = ".....",
            Jpsentence = "……",
            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",
            Thaisentence = "เฮะๆ เธอก็ไม่รู้เหมือนกันหรอ…",
            ENGsentence = "Heh, you don’t know either?",
            Jpsentence = "へえ、あんたも知らないのか……",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],
            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",
            Thaisentence = "แล้ว ทำไมนายถึงอยู่ที่นี่ละ",
            ENGsentence = "Then why are you here?",
            Jpsentence = "じゃあ、なんでお前はここにいるんだ？",
            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Rei",
            Thaisentence = "กำลังหาทางหนีออกจากเมืองน่ะ",
            ENGsentence = "I’m trying to find a way to escape the city.",
            Jpsentence = "街から逃げる方法を探しているんだ。",
            speakerImage = REI[0],
            SmallImage = SmallREI[0],
            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",
            Thaisentence = "ทำไมละ?",
            ENGsentence = "Why?",
            Jpsentence = "なぜだ？",
            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " เมืองนี้น่ะกำลังจะล่มสลายแล้วล่ะ เธอเองก็ควรรีบหนีด้วยนะ\r\n",
            ENGsentence = " This city is about to collapse. You should run too.\r\n",
            Jpsentence = " この街はもうすぐ崩壊する。あんたも早く逃げた方がいい。",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " เมืองนี้น่ะกำลังจะล่มสลายแล้วล่ะ เธอเองก็ควรรีบหนีด้วยนะ\r\n",
            ENGsentence = " This city is about to collapse. You should run too.\r\n",
            Jpsentence = " この街はもうすぐ崩壊する。きみも早く逃げた方がいい。",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = "  ก่อนที่ MirEbon จะกลืนกินทุกสิ่งในเมือง…\r\n",
            ENGsentence = "  Before MirEbon devours everything in the city…\r\n",
            Jpsentence = " MirEbonが街のすべてを飲み込む前に……",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",

            Thaisentence = " เอาเถอะ เราเองก็ไม่คิดจะอยู่ที่นี่นานเหมือนกัน\r\n",
            ENGsentence = " Whatever, I don’t plan to stay here long either.\r\n",
            Jpsentence = " まあいい、われも長居するつもりはない。\r\n",

            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",

            Thaisentence = " แต่ก่อนอื่นเลย ไอ้ MirEbon เนี่ย คืออะไรกัน",
            ENGsentence = "　But first, what exactly is this MirEbon?\r\n",
            Jpsentence = " だがまず最初に、そのMirEbonって何だ？\r\n",

            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " ...เธอไม่รู้จักหรอ?\r\n",
            ENGsentence = " …You don’t know it?",
            Jpsentence = " ……知らないのか？",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",

            Thaisentence = " ถ้ารู้เราคงไม่ถามหรอก\r\n",
            ENGsentence = " If I knew, I wouldn’t be asking.",
            Jpsentence = " 知ってたら聞かないよ。",

            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = "　ไม่คิดว่าจะมีคนไม่รู้จักอยู่ด้วยแฮะ",
            ENGsentence = "　Seriously? Didn’t think someone here wouldn’t know that..\r\n",
            Jpsentence = " まさか……こんなことも知らん者が いるがな\r\n",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });




        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",

            Thaisentence = "....",
            ENGsentence = "....",
            Jpsentence = "....",

            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = "....",
            ENGsentence = "....",
            Jpsentence = "....",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " ดูเหมือนเธอจะอยู่ในคริสตัลมานานมากเลยสินะ\r\n",
            ENGsentence = " Looks like you’ve been in that crystal for a long time.",
            Jpsentence = " どうやら長い間クリスタルに閉じ込められていたようだな。",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " เดี๋ยวฉันจะอธิบายให้ฟังแล้วกัน\r\n",
            ENGsentence = " I’ll explain everything soon enough.\r\n",
            Jpsentence = " すぐに説明しよう。",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " แต่ก่อนอื่นดูเหมือนจะมีบางอย่างตามเข้ามาแล้วละ จัดการมันก่อนดีกว่า\r\n",
            ENGsentence = " But first, something seems to have followed us. Better deal with it.\r\n",
            Jpsentence = "  だがまず、何かがついてきたようだ。先に片付けよう。",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",

            Thaisentence = " เอาเถอะ ได้ยืนเส้นยืดสายหลังตื่นสักหน่อยก็ดีเหมือนกัน\r\n",
            ENGsentence = " Alright, stretching my limbs after waking up isn’t so bad.\r\n",
            Jpsentence = " まあ、起きたばかりで体を伸ばすのも悪くないな。\r\n",

            speakerImage = Xeno[4],
            SmallImage = SmallXeno[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


    }



}
