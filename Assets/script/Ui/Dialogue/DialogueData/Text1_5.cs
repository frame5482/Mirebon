using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DialogueData;
using UnityEngine.UI;

public class Text1_5 : Textbase
{ 
    
    public Sprite emty;
    public Sprite Smallemty;

    public Sprite[] Xeno;
    public Sprite[] SmallXeno;

    public Sprite[] REI;
    public Sprite[] SmallREI;

    public Sprite[] Varron;
    public Sprite[] SmallVarron;

    public Sprite[] Lycia;
    public Sprite[] SmallLycia;

    public Sprite[] BGImage;
    public Sprite[] StoryImage;


    public Sprite[] Dragon;
    


    public void Start()

    {
        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " ตรงนั้นดูเมือนเหมือนจะเป็นทางออกอุโมงแฮะ ไปกันเถอะ\r\n ",
            ENGsentence = " That looks like the tunnel exit. Let’s go.\r\n ",
            Jpsentence = " あそこはトンネルの出口みたいだ。行こう。\r\n ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",

            Thaisentence = " แล้วจะเริ่มจากที่ไหนดีละ ดูแล้วคงต้องเดินทางกันอีกไกลด้วยสิ\r\n ",
            ENGsentence = " Where should we start? Looks like it’s still a long way to go.\r\n ",
            Jpsentence = " どこから始めようか？まだかなり歩かなきゃいけなさそうだな。\r\n ",

            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " The End อยู่ทางเหนือสุดของปลายขอบโลก ตอนนี้เมืองที่ใกล้ที่สุดคงเป็นเมือง โรซาเทียร์ ละนะไปที่ั่นั่นกันก่อนดีกว่า\r\n ",
            ENGsentence = " The End lies at the northern edge of the world. The closest town now is Rosatier. Let’s go there first.\r\n ",
            Jpsentence = " The Endは世界の北端にある。今、一番近い街はロザティアだ。まずそこに行こう。\r\n ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " แต่ถึงบอกว่าใกล้ที่สุดถ้าเดินเท้าไปคงหลายวันหน่อยละนะ\r\n",
            ENGsentence = " Even though it’s the closest, it will still take several days on foot. ",
            Jpsentence = " 近いと言っても徒歩だと何日もかかるだろうな。\r\n  ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });
        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",

            Thaisentence = ".... ",
            ENGsentence = ".... ",
            Jpsentence = ".... ",

            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " …… หรือว่าไม่อยากเดินเท้าหรอ ต้องขอโทษด้วยแต่ว่าตอนนี้พวกม้าคง-\r\n ",
            ENGsentence = " …Or don’t want to walk? Sorry but the horses now probably—\r\n ",
            Jpsentence = "  ……歩きたくないのか？すまないが今は馬はたぶん—\r\n ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",

            Thaisentence = " ไม่ใช่….มีบางอย่างกำลังมาทางนี้\r\n ",
            ENGsentence = " No… Something’s coming this way.\r\n ",
            Jpsentence = " 違う…何かがこっちに来ている。\r\n ",

            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Narrator",

            Thaisentence = " ทั้งสองเดินไปแอบดู ",
            ENGsentence = " They both sneak to take a look\r\n",
            Jpsentence = " 二人はこっそり覗きに行った。\r\n ",

            speakerImage = emty,
            SmallImage = Smallemty,

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " ตราแบบนั้นการ์เดี้ยนจากเมืองโรซาเทียร์นี่นา\r\n ",
            ENGsentence = " That emblem—those are Guardians from Rosatier.\r\n ",
            Jpsentence = "  その紋章はロザティアのガーディアンだな。 ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });
        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " พอดีเลย ถ้าไปกับพวกเขาน่าจะเดินทางได้ไวมากขึ้น ไปหาพวกเขากันเถอะ ",
            ENGsentence = " Perfect timing. Traveling with them will be faster. Let’s go find them.\r\n",
            Jpsentence = " ちょうどいい。彼らと一緒なら、私たちの旅はもっと早く進めるはずだ。\r\n ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });



        TextData.Add(new DialogueData
        {
            speakerName = "Narrator",

            Thaisentence = "ทั้งสองเดินไปหาเหล่าการ์เดี้ยน\r\n",
            ENGsentence = "  They walk toward the Guardians\r\n",
            Jpsentence = " 二人はガーディアンたちに近づいた。\r\n ",

            speakerImage = emty,
            SmallImage = Smallemty,

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });



        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = "เฮ้! ทางนี้\r\n ",
            ENGsentence = " Hey! Over here!\r\n ",
            Jpsentence = " おい！こっちだ！\r\n ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });



        TextData.Add(new DialogueData
        {
            speakerName = "????",

            Thaisentence = " พวกเธอสองคน? ผู้รอดชีวิตเรอะ ?\r\n ",
            ENGsentence = "You two? Survivors?\r\n ",
            Jpsentence = "  お前ら二人か？生存者か？\r\n ",

            speakerImage = Varron[0],
            SmallImage = SmallVarron[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });
        TextData.Add(new DialogueData
        {
            speakerName = "????",

            Thaisentence = "  โชคดีที่ยังมีผู้เหลือรอด เกิดอะไรขึ้นไหนเมือง เซเลริธ กันแน่ มีคนอื่นอีกไหม? ",
            ENGsentence = " Lucky to have survivors. What happened in Celerith town? is there anyone else?\r\n ",
            Jpsentence = "   生き残りがいてよかった。セレリスの街で何があった？他に誰かいるのか？\r\n ",

            speakerImage = Varron[0],
            SmallImage = SmallVarron[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " น่าเสียดาย แต่ว่ามีแค่พวกเราสองคนเท่านั้นที่รอดมาได้ เมืองพวกเราถูก MirEbon ไปหมดแล้วละ\r\n ",
            ENGsentence = " Unfortunately, only the two of us survived. Our town was consumed by MirEbon.\r\n ",
            Jpsentence = " 残念だが、俺たち二人だけが生き残った。街はMirEbonに飲み込まれた。\r\n ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "????",

            Thaisentence = " งั้นหรอ เสียใจด้วยนะ\r\n ",
            ENGsentence = " I see. Sorry to hear that.\r\n ",
            Jpsentence = " そうか、気の毒に。 ",

            speakerImage = Varron[0],
            SmallImage = SmallVarron[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });
        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " ผม มลทินนิรันดร์ เรย์ หัวหน้าหน่วยการ์เดี้ยนของเมืองนี้น่ะ ",
            ENGsentence = " I am Eternal Blight, Rei, the leader of the Guardian unit in this town.\r\n ",
            Jpsentence = " 俺は永遠の汚れ、レイ。この街のガーディアン隊長だ。\r\n  ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });
        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = "  ส่วนทางนี้คือ เทพศาสตรา เซโน่\r\n ",
            ENGsentence = "  And this is Sacred Armament Xeno.\r\n ",
            Jpsentence = "   そしてこちらは神器セノ。",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",

            Thaisentence = ".... ",
            ENGsentence = ".... ",
            Jpsentence = ".... ",

            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });



        TextData.Add(new DialogueData
        {
            speakerName = "Varron",

            Thaisentence = " ข้า เถ้าถ่านผู้โรยรา วาร์รอน หัวหน้าหน่วยการ์เดี้ยนของเมืองโรซาเทียร์\r\n",
            ENGsentence = " I am Ashenfell Varron, leader of the Guardian unit of Rosatier town.\r\n ",
            Jpsentence = " 我は枯れた灰、ヴァロン。ロザティアのガーディアン隊長だ。 ",

            speakerImage = Varron[0],
            SmallImage = SmallVarron[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "???",

            Thaisentence = "  คุณปู่ค่ะ!!! เป็นยังไงบ้างคะ\r\n",
            ENGsentence = "  Grandpa!!! How are you?\r\n ",
            Jpsentence = " おじいさま！どうですか？ ",

            speakerImage = Lycia[0],
            SmallImage = SmallLycia[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "???",

            Thaisentence = " อ๊ะ… สวัสดีคะ ฉันมารบกวนอะไรไหมคะ\r\n",
            ENGsentence = " Ah... Hello. Am I disturbing you?\r\n ",
            Jpsentence = " あっ…こんにちは。お邪魔してますか？\r\n ",

            speakerImage = Lycia[0],
            SmallImage = SmallLycia[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Varron",

            Thaisentence = " ไม่หรอกมาได้พอดีเลย นี่หลานสาวข้า ลิเซีย\r\n",
            ENGsentence = " No, perfect timing. This is my granddaughter, Lycia.\r\n",
            Jpsentence = " いや、ちょうどよかった。こちらは孫娘のリシアだ。\r\n ",

            speakerImage = Varron[0],
            SmallImage = SmallVarron[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Lycia",

            Thaisentence = " สวัสดีคะ ลิเซียคะ แค่ลิเซียเฉยๆ เนื่องจากเป็นการ์เดี้ยนฝึกหัดเลยยังไม่ได้รับนามที่สองคะ\r\n",
            ENGsentence = " Hello, I’m Lycia. Just Lycia. Since I’m a trainee Guardian, I don’t have a second name yet.\r\n ",
            Jpsentence = " こんにちは、リシアです。まだ訓練中のガーディアンなので称号はありません。",

            speakerImage = Lycia[0],
            SmallImage = SmallLycia[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " อ่า ยินดีที่ได้รู้จักนะ\r\n ",
            ENGsentence = " Ah, nice to meet you.\r\n ",
            Jpsentence = " ああ、よろしく。\r\n  ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });





        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " อ่า ยินดีที่ได้รู้จักนะ\r\n ",
            ENGsentence = " Ah, nice to meet you.\r\n ",
            Jpsentence = " ああ、よろしく。\r\n  ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });





        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " จะว่าไปพวกคุณมาจากโรซาเทียร์สินะ พอดีเลยพวกเราวางแผนว่าจะไปที่นั่นกันพอดีเลย ระหว่างทางกลับขอติดไปด้วยได้ไหม\r\n ",
            ENGsentence = " By the way, you’re from Rosatier, right? Perfect, we plan to go there. Can we join you on the way?\r\n ",
            Jpsentence = " ところで、君たちはロザティアからか？ちょうど俺たちもそこに行くつもりだ。一緒に行ってもいいか？\r\n ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });



        TextData.Add(new DialogueData
        {
            speakerName = "Varron",

            Thaisentence = " อ่า ได้สิ ยังไงพวกเราก็ต้องช่วยผู้ประสบภัยอยู่แล้ว\r\n",
            ENGsentence = "  Sure. We have to help the victims anyway.\r\n",
            Jpsentence = "  ああ、もちろんだ。被災者を助けるのは当然だ。 ",

            speakerImage = Varron[0],
            SmallImage = SmallVarron[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Lycia",

            Thaisentence = "  ใช่แล้วคะ ยินดีต้อนรับทั้งสองท่านนะคะ\r\n",
            ENGsentence = " Yes, welcome to both of you.\r\n",
            Jpsentence = "  はい、二人とも歓迎します。",

            speakerImage = Lycia[0],
            SmallImage = SmallLycia[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",

            Thaisentence = ".... ",
            ENGsentence = ".... ",
            Jpsentence = "....",

            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });




        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " เป็นอะไรไปเซโน่ไม่พูดไม่จามาตั้งแต่มะกี้แล้วนะ\r\n ",
            ENGsentence = " What’s wrong, Xeno? You’ve been quiet since before.\r\n",
            Jpsentence = " どうした、セノ？さっきから黙っているが。\r\n ",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });



        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",

            Thaisentence = " เรย์เอ๋ย… ที่เราบอกว่ามีบางอย่างกำลังมาไม่ได้หมายถึงสองคนนี้หรอกนะ\r\n ",
            ENGsentence = " Rei... When I said something was coming, I didn’t mean these two.\r\n ",
            Jpsentence = " レイよ…俺が何か来ると言ったのはこの二人のことじゃない。 ",

            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " …… หรือว่า!!\r\n",
            ENGsentence = " …Could it be!!\r\n",
            Jpsentence = " ……まさか！！\r\n",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Narrator",

            Thaisentence = "ตู้มมมมม!\r\n",
            ENGsentence = " Boom!",
            Jpsentence = " ドーン！\r\n ",

            speakerImage = Dragon[0],
            SmallImage = Smallemty,

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


        TextData.Add(new DialogueData
        {
            speakerName = "Narrator",

            Thaisentence = "คลืนนนน!!\r\n",
            ENGsentence = " Roar!",
            Jpsentence = "  ゴオオオオ！\r\n ",

            speakerImage = Dragon[1],
            SmallImage = Smallemty,

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Narrator",

            Thaisentence = "มังกรแดงขนาดยักษ์ปรากฏตัวออกมา",
            ENGsentence = "  A red dragon appears\r\n!",
            Jpsentence = "   赤い竜が現れた。！\r\n ",

            speakerImage = emty,
            SmallImage = Smallemty,

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });



        TextData.Add(new DialogueData
        {
            speakerName = "Varron",

            Thaisentence = " หื้ม?? มังกรเรอะ มาอยู่แถวนี้ได้ยังไงกัน\r\n",
            ENGsentence = " Hmm?? A dragon? How come it’s here?\r\n",
            Jpsentence = " ん？竜か？なんでこんなところにいるんだ？\r\n ",

            speakerImage = Varron[0],
            SmallImage = SmallVarron[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Lycia",

            Thaisentence = " คุณเรย์คะ มังกรแดงตัวนี้มันอะไรกัน\r\n",
            ENGsentence = " Rei, what is this red dragon?\r\n",
            Jpsentence = "  レイさん、この赤い竜は何ですか？\r\n",

            speakerImage = Lycia[0],
            SmallImage = SmallLycia[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });



        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " เวลโรซ่า เป็นมังกรที่อาศัยอยู่ในภูเขาใกล้ๆเมืองนี้น่ะ\r\n",
            ENGsentence = " Velrosa is a dragon living in the mountains near this town.\r\n",
            Jpsentence = " ヴェルローザはこの街近くの山に住む竜だ。\r\n",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " แต่ว่าปกติแล้วมันไม่ดุร้ายขนาดนี้ แถมบางครั้งยังมาช่วยเราป้องกันเมืองด้วยซ้ำ\r\n",
            ENGsentence = " But normally it’s not this aggressive, sometimes it even helps protect the town.\r\n",
            Jpsentence = " でも普段はこんなに凶暴じゃない。時々街の防衛も手伝ってくれるんだ。\r\n",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " แต่ว่าตอนนี้น่ะ เกรงว่า…..",
            ENGsentence = " But now, I fear that…\r\n",
            Jpsentence = " だが今は…恐らく…\r\n",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Varron",

            Thaisentence = "  งั้นหรอ….ถูก MirEbon เข้ากลืนกินสินะ\r\n",
            ENGsentence = " I see… It’s been consumed by MirEbon.",
            Jpsentence = " そうか…MirEbonに飲み込まれたな。\r\n ",

            speakerImage = Varron[0],
            SmallImage = SmallVarron[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });



        TextData.Add(new DialogueData
        {
            speakerName = "Xeno",

            Thaisentence = " เอาไว้คุยกันทีหลัง ตอนนี้ต้องจัดการมันก่อน ",
            ENGsentence = " We’ll talk later. We have to deal with it now.\r\n ",
            Jpsentence = " 後で話そう。今は対処しなければ。\r\n ",

            speakerImage = Xeno[0],
            SmallImage = SmallXeno[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });

        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = ".....",
            ENGsentence = " .....",
            Jpsentence = " .....",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });
        TextData.Add(new DialogueData
        {
            speakerName = "Rei",

            Thaisentence = " เข้าใจแล้ว….\r\n",
            ENGsentence = "  Understood…\r\n",
            Jpsentence = "  わかった…。\r\n",

            speakerImage = REI[0],
            SmallImage = SmallREI[0],

            BGImage = BGImage[0],
            StoryImage = StoryImage[0]
        });


    }



}
