using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class QuizChoices : MonoBehaviour
{
    public GameObject Answer1;
    public GameObject Answer2;
    public GameObject Answer3;
    public GameObject Answer4;
    public GameObject Answer5;
    public GameObject Back;

    public GameObject character;


    //   int c = GrannyAnimations.getCharacter();

    public GameObject A1;
    public GameObject A2;
    public GameObject A3;
    public GameObject A4;
    public GameObject A5;
    public int c;

    public void Start()
    {
        c = GameObject.Find("YogaCharacter").GetComponentInChildren<GrannyAnimations>().getCharacter();
     
    }
    public void Update()
    {
        Debug.Log("Char number " + c);
        //   Debug.Log("Character " + c);
        if (c == 0)
        {
            A1.GetComponentInChildren<Text>().text = "Giving or buying him or her items needed to carry out rituals, such as soap for hand washing.";
            A2.GetComponentInChildren<Text>().text = "Stop thinking about it!";
            A3.GetComponentInChildren<Text>().text = "You have an amazing life! You should not obsess over insignificant things.";
            A4.GetComponentInChildren<Text>().text = "I wish I had OCD";
            A5.GetComponentInChildren<Text>().text = "Getting involved in rituals by checking door locks, helping decontaminate clothing, food or even entire rooms with him. ";
            Answer1.GetComponentInChildren<Text>().text = "Right!";
            Answer2.GetComponentInChildren<Text>().text = "Wrong. If people with OCD could stop their unwanted thoughts, they would do that right away, because believe me: obsessing over irrational things and wasting your time on compulsions is not fun. Let’s not even mention the severe anxiety. However, the problem is that the harder you try to fight your disturbing thoughts, the more likely you will get them ";
            Answer3.GetComponentInChildren<Text>().text = "Wrong. Doubt is a terrible feeling but it is not the only one that people with OCD have to cope with. Guilt can turn your life into a nightmare too.";
            Answer4.GetComponentInChildren<Text>().text = "Wrong. It is not fun! One of the common misconceptions is that Obsessive Compulsive Disorder can be useful. ";
            Answer5.GetComponentInChildren<Text>().text = "Right!";
        }if (c == 1)
        {
            A1.GetComponentInChildren<Text>().text = "Cheer up";
            A2.GetComponentInChildren<Text>().text = "It could be worse.";
            A3.GetComponentInChildren<Text>().text = "Ask How You Can Help.";
            A4.GetComponentInChildren<Text>().text = "BECOME A PSYCHOLOGIST to him/her";
            A5.GetComponentInChildren<Text>().text = "Urge Them to Talk With a Doctor.";
            Answer1.GetComponentInChildren<Text>().text = "Wrong. cheer up or smile may feel friendly and supportive to you, but they oversimplify the feelings of sadness associated with depression. Just as someone who is depressed can't force their brain to make more serotonin, they also can't just decide to be happy. While there are certainly benefits to practicing positive thinking,2 it's not enough to cure someone of depression. YOU CAN Better Remind Them It's OK to Feel This Way";
            Answer2.GetComponentInChildren<Text>().text = "Wrong. People with depression also lack the internal resources needed to cope with stress in an effective and healthy way.4 To you, an event or situation that constitutes a minor annoyance or inconvenience may feel like an insurmountable obstacle to your loved one with depression. YOU CAN Better Tell Them You Care. These two simple words—“I care”—can mean so much to a person who may be feeling like the entire world is against them.";
            Answer3.GetComponentInChildren<Text>().text = "Right! Depression places a great weight on the person who is experiencing it, both physically and mentally,4so there are probably many things you can do to ease the burden as your friend recovers. Your friend may be reluctant to accept your offer for fear of becoming a burden on you, so make it clear that you don't mind and want to help in the same way you know they would for you in a similar situation.";
            Answer4.GetComponentInChildren<Text>().text = "Wrong. DON’T BECOME A PSYCHOLOGIST and start diagnosing them or trying to give advice beyond your knowledge – that is best left to the professionals. Just listen to them, believe everything they tell you and let them know you’ll love and support them every step of the way.";
            Answer5.GetComponentInChildren<Text>().text = "Right! If your friend has not yet seen a doctor, encourage them to seek help and reassure them that there is nothing wrong with asking for assistance. Depression is a real—and treatable—illness. If your friend is already seeing a doctor, offer to help with picking up medications and being on time for appointments. ";
        }if (c == 2)
        {
            A1.GetComponentInChildren<Text>().text = "I know what you mean. I had a panic attack.";
            A2.GetComponentInChildren<Text>().text = "Let’s  go for a walk.";
            A3.GetComponentInChildren<Text>().text = "Why aren’t you seeing a therapist/on medication?";
            A4.GetComponentInChildren<Text>().text = "Have you tried meditation/yoga? ";
            A5.GetComponentInChildren<Text>().text = "Just relax";
            Answer1.GetComponentInChildren<Text>().text = "Wrong. There’s a difference between the uncomfortable but rational anxiety we all get in stressful situations and the sometimes paralyzing but illogical anxiety super anxious people like me get in situations that aren’t actually stressful or threatening. People with anxiety disorders experience anxiety over things others wouldn’t and with such intensity that it interferes with our ability to function and do things we enjoy. So unless you have a diagnosable anxiety disorder, comparing your anxiety to someone else’s isn’t helpful. Instead say: “I’m always here for you.” ";
            Answer2.GetComponentInChildren<Text>().text = "Right!";
            Answer3.GetComponentInChildren<Text>().text = "Wrong. There’s nothing wrong with showing concern for a friend, but be careful it doesn’t come across as accusatory. Suggesting your friend should be doing something can create a sense of shame if they aren’t, or make them feel like they’re being judged. If they do need to see a counselor or take medication, those are decisions they need to make on their own and at their own pace. ";
            Answer4.GetComponentInChildren<Text>().text = "Wrong. Meditation and yoga and deep breathing and all of the other anti-anxiety trends that have taken pop culture by storm might be helpful for some people, maybe even your ultra-anxious friend. But they might not. Extreme anxiety can feel consuming, which means that small things like taking a few deep breaths might not be enough to counter panic in the moment. Instead say: “What can I do to help you?” ";
            Answer5.GetComponentInChildren<Text>().text = "Telling someone they should relax will definitely not help them overcome their anxiety. I wish relaxation could solve all the problems – but it does not. ";
        }if (c == 3)
        {
            A1.GetComponentInChildren<Text>().text = "Everybody Has Mood Swings Sometimes.";
            A2.GetComponentInChildren<Text>().text = "Everyone Is a Little Bipolar Sometimes.";
            A3.GetComponentInChildren<Text>().text = "You're Acting Like a Maniac.";
            A4.GetComponentInChildren<Text>().text = "Your illness doesn't define who you are. You are still you, with hopes and dreams you can attain.";
            A5.GetComponentInChildren<Text>().text = "I might not know how you feel, but I'm here to support you.";
            Answer1.GetComponentInChildren<Text>().text = "Wrong. Only people with bipolar disorder, cyclothymia, schizoaffective disorder, and related severe mental illnesses have repeated and severe mood swings between mania or hypomania and depression. ";
            Answer2.GetComponentInChildren<Text>().text = "Wrong. This similar phrase is insensitive for the same reasons. Having mood swings is not the same as having a diagnosable disorder.";
            Answer3.GetComponentInChildren<Text>().text = "Wrong. This one is extremely offensive, as maniacs are portrayed as violent and deranged. Experiencing bipolar mania does not automatically mean that a person will be dangerous. It's also not the same thing as antisocial personality disorder and/or being psychopathic.5 ";
            Answer4.GetComponentInChildren<Text>().text = "Right!";
            Answer5.GetComponentInChildren<Text>().text = "Right!";
        }
        if (c == 4)
        {
            A1.GetComponentInChildren<Text>().text = "Everyone gets distracted sometimes";
            A2.GetComponentInChildren<Text>().text = "You just need to be a better listener";
            A3.GetComponentInChildren<Text>().text = "Remind Them They Are Loved ";
            A4.GetComponentInChildren<Text>().text = "Ask Questions ";
            A5.GetComponentInChildren<Text>().text = "I know how you feel";
            Answer1.GetComponentInChildren<Text>().text = "WRONG. 'ADHD is so much more than just 'getting distracted sometimes' and it’s frustrating when people assume that. Only we truly understand what it’s like to live with ADHD.'—addisonnelson";
            Answer2.GetComponentInChildren<Text>().text = "WRONG. 'I'm so tired of always hearing 'you should listen better... if you were listening you would know... you obviously don't care or you would have listened.' I'm aware, but the constant reminders are like being slapped over and over again.' Abraham Knoff, Facebook";
            Answer3.GetComponentInChildren<Text>().text = "RIGHT. GOOD CHOICE";
            Answer4.GetComponentInChildren<Text>().text = "Right. make a safe space for them without any judgements.";
            Answer5.GetComponentInChildren<Text>().text = "Don't say, 'I know how you feel,' (unless you also have ADHD). It minimizes what they're going through. ";
        }
        if (c == 5)
        {
            A1.GetComponentInChildren<Text>().text = "I like your hair/bag/shoes/etc.";
            A2.GetComponentInChildren<Text>().text = "YOU AREN’T FAT! YOU LOOK SO HEALTHY!  ";
            A3.GetComponentInChildren<Text>().text = "YOU ARE SO SKINNY! WHAT IS YOUR SECRET? I WISH I HAD YOUR WILLPOWER! ";
            A4.GetComponentInChildren<Text>().text = "ISN’T THAT TOO MUCH FOOD? DO YOU KNOW HOW MANY CALORIES ARE IN THAT? ";
            A5.GetComponentInChildren<Text>().text = "•	I love you no matter what";
            Answer1.GetComponentInChildren<Text>().text = "Right.Everyone likes to get a compliment every now and then, but avoid saying 'you look healthy / good' because this could be heard as 'you look bigger' in the ears of someone in the early stages of recovery. However, giving a compliment about hair, shoes or maybe even their make-up can boost confidence and make the other feel better about themselves ";
            Answer2.GetComponentInChildren<Text>().text = "Wrong. •	To the ears of someone with an ED, this does not translate to the well-meaning comment it was likely intended. Healthy to someone with an eating disorder or a distorted body image does not have a positive connotation. The best thing you can do is to not comment on body size at all. ";
            Answer3.GetComponentInChildren<Text>().text = "Wrong. •	Okay, this is actually something you shouldn’t say to anyone, period. This can be especially problematic to someone with an active eating disorder or those vulnerable to disordered eating, as it can be the validation their ED is seeking. To them, it says that their efforts are not only working, but that their underlying belief that being in a smaller body makes them more worthy, acceptable and interesting is true. This kind of praise places emphasis on appearance being a source of value, reinforcing the idea that a smaller body is more valuable.";
            Answer4.GetComponentInChildren<Text>().text = "Wrong. •	First of all, commenting on anyone’s food choices is never a good idea. It’s likely to cause unnecessary food preoccupation and feeling self-conscious about food choices. A person with an ED is likely already hyper-aware of their food choices and feel that others are watching them eat. Commending on their food choices only affirms their fear that their eating is being observed and is on trial.";
            Answer5.GetComponentInChildren<Text>().text = "Right";
        }
    }
    public void Choice1()
    {
        if (A1)
        {
            A1.SetActive(false);

        }
        if (A2)
        {
            A2.SetActive(false);

        }
        if (A3)
        {
            A3.SetActive(false);

        }
        if (A4)
        {
            A4.SetActive(false);

        }

        if (A5)
        {
            A5.SetActive(false);

        }
        Destroy(A1);
        Back.SetActive(true);

        Answer1.SetActive(true); Answer2.SetActive(false); Answer3.SetActive(false); Answer4.SetActive(false); Answer5.SetActive(false);
    }
    public void Choice2()
    {
        if (A1)
        {
            A1.SetActive(false);

        }
        if (A2)
        {
            A2.SetActive(false);

        }
        if (A3)
        {
            A3.SetActive(false);

        }
        if (A4)
        {
            A4.SetActive(false);

        }

        if (A5)
        {
            A5.SetActive(false);

        }

        Destroy(A2);
        Back.SetActive(true);
        Answer1.SetActive(false); Answer2.SetActive(true); Answer3.SetActive(false); Answer4.SetActive(false); Answer5.SetActive(false);
    }
    public void Choice3()
    {
        if (A1)
        {
            A1.SetActive(false);

        }
        if (A2)
        {
            A2.SetActive(false);

        }
        if (A3)
        {
            A3.SetActive(false);

        }
        if (A4)
        {
            A4.SetActive(false);

        }

        if (A5)
        {
            A5.SetActive(false);

        }
        Destroy(A3);
        Back.SetActive(true);
        Answer1.SetActive(false); Answer2.SetActive(false); Answer3.SetActive(true); Answer4.SetActive(false); Answer5.SetActive(false);
    }
    public void Choice4()
    {
        if (A1)
        {
            A1.SetActive(false);

        }
        if (A2)
        {
            A2.SetActive(false);

        }
        if (A3)
        {
            A3.SetActive(false);

        }
        if (A4)
        {
            A4.SetActive(false);

        }

        if (A5)
        {
            A5.SetActive(false);

        }
        Destroy(A4);
        Back.SetActive(true);
        Answer1.SetActive(false); Answer2.SetActive(false); Answer3.SetActive(false); Answer4.SetActive(true); Answer5.SetActive(false);
    }

    public void Choice5()
    {

        if (A1)
        {
            A1.SetActive(false);

        }
        if (A2)
        {
            A2.SetActive(false);

        }
        if (A3)
        {
            A3.SetActive(false);

        }
        if (A4)
        {
            A4.SetActive(false);

        }

        if (A5)
        {
            A5.SetActive(false);

        }
        Destroy(A5);
        Back.SetActive(true);
        Answer1.SetActive(false); Answer2.SetActive(false); Answer3.SetActive(false); Answer4.SetActive(false); Answer5.SetActive(true);
    }

    public void BackPressed()
    {
        if (A1)
        {
            A1.SetActive(true);

        }
        if (A2)
        {
            A2.SetActive(true);

        }
        if (A3)
        {
            A3.SetActive(true);

        }
        if (A4)
        {
            A4.SetActive(true);

        }

        if (A5)
        {
            A5.SetActive(true);

        }

        if (Answer1)
        {
            Answer1.SetActive(false);

        }
        if (Answer2)
        {
            Answer2.SetActive(false);

        }
        if (Answer3)
        {
            Answer3.SetActive(false);

        }
        if (Answer4)
        {
            Answer4.SetActive(false);

        }
        if (Answer5)
        {
            Answer5.SetActive(false);

        }


        Back.SetActive(false);

        if (!A1 && !A2 && !A3 && !A4 & !A5)
        {
            //       Debug.Log("SCENEEEES");
            SceneManager.UnloadSceneAsync("Quiz");
            //        SceneManager.LoadScene("GardenScene", LoadSceneMode.Additive);
            //        SceneManager.SetActiveScene(SceneManager.GetSceneByName("GardenScene"));
        }

    }
}
