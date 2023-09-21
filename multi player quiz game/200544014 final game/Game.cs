using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_Sharp_Game
{//rahi patel
    //200544014
    //forest survival quiz
    internal class Game
    {
        // ascii charactar variable
        //for wlcome
        public string wel = @"
 .       __ .____  .       ___    ___   __   __ .____ 
 /       |  /      /     .'   \ .'   `. |    |  /     
 |       |  |__.   |     |      |     | |\  /|  |__.  
 |  /\   /  |      |     |      |     | | \/ |  |     
 |,'  \,'   /----/ /---/  `.__,  `.__.' /    /  /----/
         
";
        //all level ascii arts with diffrent style
        public string le1 = @"
██      ███████ ██    ██ ███████ ██           ██ 
██      ██      ██    ██ ██      ██          ███ 
██      █████   ██    ██ █████   ██           ██ 
██      ██       ██  ██  ██      ██           ██ 
███████ ███████   ████   ███████ ███████      ██ 
                                                 ";
        public string le2 = @"
██      ███████ ██    ██ ███████ ██          ██████  
██      ██      ██    ██ ██      ██               ██ 
██      █████   ██    ██ █████   ██           █████  
██      ██       ██  ██  ██      ██          ██      
███████ ███████   ████   ███████ ███████     ███████ 
                                                     
                                                     ";
        public string le3 = @"
██      ███████ ██    ██ ███████ ██          ██████  
██      ██      ██    ██ ██      ██               ██ 
██      █████   ██    ██ █████   ██           █████  
██      ██       ██  ██  ██      ██               ██ 
███████ ███████   ████   ███████ ███████     ██████  
                                                     
                                                     ";
//emojis happy and sad for end of the level
        public string sad = @"
     .-""""""-.
   .'          '.
  /   O      O   \
 :           `    :
 |                |   
 :    .------.    :
  \  '        '  /
   '.          .'
     '-......-'
"; //sad emoji

        public string happy = @"
     .-""""""-.
   .'          '.
  /   O    -=-   \
 :                :
 |                |  
 : ',          ,' :
  \  '-......-'  /
   '.          .'
     '-......-'"

;
        //happy emoji

        //congrats if they win the game

        public string con = @"
                                                          ,---. 
                                             ,--.         |   | 
 ,---. ,---. ,--,--,  ,---. ,--.--. ,--,--.,-'  '-. ,---. |  .' 
| .--'| .-. ||      \| .-. ||  .--'' ,-.  |'-.  .-'(  .-' |  |  
\ `--.' '-' '|  ||  |' '-' '|  |   \ '-'  |  |  |  .-'  `)`--'  
 `---' `---' `--''--'.`-  / `--'    `--`--'  `--'  `----' .--.  
                     `---'                                '--'  ";


        // variable declaration

        public string user = "";
        public int scorel1 = 0; // score for l1
        public int scorel2 = 0; // score for l2
        public int scorel3 = 0; // score for l3


        //level 1 questions and answers and options
        public string[] ql1 = { "Which of the following should you prioritize when setting up camp in the jungle?", "What should you do if you encounter a snake while walking through the jungle?", "What is the best way to filter water in the jungle?", "How should you handle an encounter with a wild animal in the jungle?" }; // array of questions for level 1
        public string[] ol1 = { "1) Shelter from the rain\r\n2) A clear view of the surroundings\r\n3) Close proximity to water sources", "1) Remain still and wait for it to pass\r\n2) Quickly move away from the snake\r\n3) Make loud noises to scare the snake away", "1) Boiling it over a fire\r\n2) Using a water filtration system\r\n3) Collecting rainwater", "1) Stay still and avoid eye contact\r\n2) Make loud noises and try to scare the animal away\r\n3) Slowly back away and avoid turning your back on the animal" };
        public string[] ansl1 = { "1", "2", "2", "3" };

        //level 2 questions and answers and options
        public string[] ql2 = { "What is the most important tool for starting a fire in the jungle?", "What should you do if you become lost in the jungle?", "How can you protect yourself from mosquitoes in the jungle?", "Which of the following is the best food source in the jungle?\r\n" };
        public string[] ol2 = { "1) A lighter or matches\r\n2) Dry tinder and kindling\r\n3) A magnifying glass", "1) Stay put and wait for rescue\r\n2) Follow a nearby stream or river\r\n3) Climb to high ground for a better view of your surroundings", "1) Wear long sleeves and pants\r\n2) Use insect repellent\r\n3) Build a smoke fire to keep them away", "1) Fruits and vegetables\r\n2) Small animals and insects\r\n3) Fish caught from a nearby stream or river" };
        public string[] ansl2 = { "2", "1", "2", "1" };

        //level 3 questions and answers and options
        public string[] ql3 = { "What should you do if you are injured in the jungle and do not have medical supplies?", "What is the best way to signal for rescue in the jungle?", "What should you do if you accidentally ingest poisonous plants in the jungle?", "What is the best way to navigate through the jungle?" };
        public string[] ol3 = { "1) Make a splint out of branches or other materials\r\n2) Apply pressure to the wound to stop bleeding\r\n3) Rest and wait for rescue", "1) Build a large fire\r\n2) Blow a whistle or make loud noises\r\n3) Create a visible signal using rocks, branches, or other materials", "1) Induce vomiting\r\n2) Drink plenty of water to flush out the toxins\r\n3) Seek medical attention immediately", "1) Follow established trails or paths\r\n2) Use a compass and map\r\n3) Use the sun and stars to determine direction." };
        public string[] ansl3 = { "2", "3", "3", "2" };

        //varible for question number as an arrey
        public int[] qn = { 1, 2, 3, 4 };

        //use of multidimention arreys
        public string[,] prizes = { { "GPS device", "Satellite phone ", "Water filter", "Solar charger", "Multi-tool" }, { "Paracord", "First aid kit", "Emergency blanket", "Portable stove", "Headlamp" } };

        //methods stars from here

        // calling class1 of method overloading
        Class1 Sco = new Class1();
        //loop for designing
        public void design()
        {
            for (int i = 0; i < 70; i++)//use of for loop to print - 7o times for design
            {
                Console.Write('-');

            }
            Console.WriteLine();// to start a nwe line
        }

        //WELCOME LOOP
        public void Welcome()
        {

            Console.WriteLine(wel);//printing ascii arts

            design();//calling design method for little for style
            Console.WriteLine("FOREST SURVIVAL QUIZ");
            design();

        }

        //loop to know the name of the person and explain them rules of game.
        public void Rulename()
        {
            design();
            Console.Write("Please Enter your name here: ");//asking user
            string username = Console.ReadLine();//getting user input
            user = username.ToUpper();//converting input to upper
            Console.WriteLine($"\nHi {user},\nLet's know some rules of the Game.");//printing with string
            Console.WriteLine();
            Console.WriteLine();
            design();// calling method
            Console.WriteLine("Here are some rules of the game....");//explaining rules
            design();
            Console.WriteLine("1) There are three levels in the game.");
            Console.WriteLine("2)In each level there are 4 question.");
            Console.WriteLine("3)You have to guess 3 right answer to move on to next level OR you have to repeat it.");
            Console.WriteLine("After three level you will win, and get the cookie!");
            Console.WriteLine();
            Console.WriteLine("....");
            // printing unusal fonts to enhance user experiance
            Console.WriteLine("ShOuLd wE sTaRt ...!\n Yes, OF COURSE... Press Enter to start...");
            Console.ReadLine();//wait user to move forward

        }

        //warmuploop
        public void warmup()
        {
            design();
            Console.WriteLine($"Hey {user}, You want to warm up before you start the game.");//asking user if they want to warmup before quiz
            design();
            string and = "";
            while (and != "Y" && and != "N" && and != "y" && and != "n") //error handling with while
            {
                Console.WriteLine("\n press y/n\n");
                and = Console.ReadLine();

            }
            string an2 = and.ToUpper();
            int gn = 0;
            if (and == "y" || and == "Y")//use of if else
            {
                try//exception handling using try and catch
                {
                    design();
                    Console.WriteLine("Select One digit from 1 to 9 to know plus point about yourself ");//asking user
                    design();
                    gn = Convert.ToInt16(Console.ReadLine());//waiting for user input and convert that into integer 16bit 
                    switch (gn)//use of swich case with gn variable
                    {
                        //diffrent-diffrent charactor of humans only good
                        case 1:
                            Console.WriteLine($"You selected {gn} \n Honesty: A good person is truthful and transparent in their actions and words.\r\n\r\n");
                            break;
                        case 2:
                            Console.WriteLine($"You selected {gn} \n Kindness: A good person is compassionate and considerate of others, often going out of their way to help those in need.\r\n\r\n");
                            break;
                        case 3:
                            Console.WriteLine($"You selected {gn} \n Integrity: A good person has strong moral principles and acts according to their values, even when it may be difficult.\r\n\r\n");
                            break;
                        case 4:
                            Console.WriteLine($"You selected {gn} \nResponsibility: A good person takes ownership of their actions and is accountable for their mistakes.\r\n\r\n ");
                            break;
                        case 5:
                            Console.WriteLine($"You selected {gn} \nEmpathy: A good person is able to understand and share the feelings of others, showing care and concern for their well-being.\r\n\r\n ");
                            break;
                        case 6:
                            Console.WriteLine($"You selected {gn} \nHumility: A good person is humble, recognizing their own limitations and giving credit to others when it is due.\r\n\r\n ");
                            break;
                        case 7:
                            Console.WriteLine($"You selected {gn} \nCourage: A good person is brave and willing to stand up for what they believe in, even in the face of adversity.\r\n\r\n ");
                            break;
                        case 8:
                            Console.WriteLine($"You selected {gn} \nPerseverance: A good person is persistent and does not give up easily, working hard to achieve their goals.\r\n\r\n ");
                            break;
                        case 9:
                            Console.WriteLine($"You selected {gn} \nGenerosity: A good person is generous, willing to give their time, resources, and support to others without expecting anything in return.\r\n\r\n\r\n\r\n ");
                            break;
                        default://one default if user input something wrong
                            Console.WriteLine($"You selected something else. ");
                            break;
                    }
                }
                catch 
                {
                    Console.WriteLine("Error please select from 1 to 9");//printing error message.

                }
                
                Console.WriteLine("press enter to continue the game.");
                design();
                Console.ReadLine();

            }
            else//else if they dont want to play this level
            {
                Console.WriteLine("You selected no or something else.\n press enter to continue the game.");
                Console.ReadLine();
            }



        }


        //level 1 loop
        public void Level1()
        {
            do
            {
                scorel1 = 0;//setting score l1 to 0 for good calculation
                Console.WriteLine(le1);//printing level 1 ascii arts
                for (int i = 0; i < 4; i++)//use of for loop
                {
                    design();
                    Console.WriteLine("Question " + qn[i]);//printing que no
                    design();
                    Console.WriteLine(ql1[i]);//printing options
                    Console.WriteLine(ol1[i]);
                    string answer = "";
                    while (answer != "1" && answer != "2" && answer != "3")//taking user input with error handling
                    {
                        Console.WriteLine("\n Select your answer from 1/2/3 and only input number as your answer.\n else your answer will be marked wrong");
                        answer = Console.ReadLine();
                    }

                    if (answer == ansl1[i])//checking answer is correct or not with if else.
                    {
                        Console.WriteLine("Boom ! you select the right one....\n You got 1 point.");
                        scorel1++;

                    }
                    else
                    {
                        Console.WriteLine("Ooops! You guess the wrong answer.... \n Be careful in the next one.");//showing user that answer is wrong
                    }
                    Console.Write("\nPress any key to continue....");
                    Console.ReadLine();


                }
                Console.WriteLine();
                design();
                design();
                Console.WriteLine($"Your total score is {scorel1} out of 4");//printing score
                design();
                design();

                if (scorel1 < 3)//checking that score is more than 3 or not
                {
                    Console.WriteLine("Repeat the level ..." + sad);
                }
                else//if user pass the level
                {
                    Console.WriteLine("Continue to the next level ..." + happy);
                }
                Console.ReadLine();

            }
            while (scorel1 < 3);//use of do while level
        }

        //level 2
        public void Level2()
        {
            do
            {
                scorel2 = 0; // setting score 2 0
                Console.WriteLine(le2);
                for (int i = 0; i < 4; i++)
                {
                    design();
                    Console.WriteLine("Question " + qn[i]);
                    design();//printing que with design
                    Console.WriteLine(ql2[i]);
                    Console.WriteLine(ol2[i]);
                    string answer = "";
                    while (answer != "1" && answer != "2" && answer != "3")//error handling in user input
                    {
                        Console.WriteLine("\n Select your answer from 1/2/3 and only input number as your answer.\n else your answer will be marked wrong");
                        answer = Console.ReadLine();
                    }
                    if (answer == ansl2[i])//if else to check the answer
                    {
                        Console.WriteLine("Boooom ! you select the right one....\n You got 1 point.");
                        scorel2++;

                    }
                    else
                    {
                        Console.WriteLine("Ooops! You guess the wrong answer.... \n Be careful in the next one.");
                    }
                    Console.Write("\nPress any key to continue....");
                    Console.ReadLine();


                }
                Console.WriteLine();
                design();
                design();
                int s2 = Sco.Add(scorel1, scorel2);//method overloading to showcase the score of level 2
                Console.WriteLine($"\nYour total score is {s2} out of 8");
                design();
                design();

                if (scorel2 < 3)//checking that user can move to next level or not
                {
                    Console.WriteLine("Repeat the level ..." + sad);
                }
                else
                {
                    Console.WriteLine("Continue to the next level ..." + happy);
                }
                Console.ReadLine();

            }
            while (scorel2 < 3);//do while loop end for level 2
        }

        //level 3 loop
        public void Level3()
        {
            do
            {
                scorel3 = 0;//setting level 3 score 0
                Console.WriteLine(le3);//printing ascci arts
                for (int i = 0; i < 4; i++)//use of for loop
                {
                    design();
                    Console.WriteLine("Question " + qn[i]);//printing que
                    design();
                    Console.WriteLine(ql3[i]);//printing options
                    Console.WriteLine(ol3[i]);
                    string answer = "";
                    while (answer != "1" && answer != "2" && answer != "3")//error handling
                    {
                        Console.WriteLine("\n Select your answer from 1/2/3 and only input number as your answer.\n else your answer will be marked wrong");
                        answer = Console.ReadLine();
                    }
                    if (answer == ansl3[i])// checking answer
                    {
                        Console.WriteLine("Boooom ! you select the right one....\n You got 1 point.");
                        scorel3++;

                    }
                    else
                    {
                        Console.WriteLine("Ooops! You guess the wrong answer.... \n Be careful in the next one.");
                    }
                    Console.Write("\nPress any key to continue....");
                    Console.ReadLine();


                }
                Console.WriteLine();
                design();
                design();
                int s3 = Sco.Add(scorel1, scorel2, scorel3);//use of method overloading
                Console.WriteLine($"Your total score is {s3} out of 12");
                design();
                design();

                if (scorel3 < 3)
                {
                    Console.WriteLine("Repeat the level ..." + sad);
                }
                else
                {
                    Console.WriteLine("You completed all levels"+happy);//printing the emoji
                }
                Console.ReadLine();

            }
            while (scorel3 < 3);
        }
        public void Prize() //loop to get prizes to the winner
        {
            design();
            design();
            Console.WriteLine(con);//print congrats
            design();
            design();
            Console.WriteLine("YOU WIN THE GAME");
            design();
            design();//use designs
            design();
            Console.WriteLine("press enter to get your winning prize.");//asking user
            design();
            Console.ReadLine();
            Random random = new Random();//calling random
            int i1 = random.Next(0, 2); //use of random
            int i2 = random.Next(0, 5);
            design();
            Console.WriteLine($"{user}, You won the \\ {prizes[i1, i2]} //. \nthat you can use in the next part of the game");//declaring prize with username and random prize
            design();
            design();
        }
        int repeat = 0;
        public void finale()// making final loop to set up all the methods
        {
            while (repeat == 0)//while loop
            {//calling all methods
                Welcome();
                Rulename();
                warmup();
                Level1();
                Level2();
                Level3();
                Prize();
                Console.WriteLine("press any key to exit \n press Y to play again.");//asking user if they want to repeat
                string ui = Console.ReadLine();
                if (ui == "Y" || ui == "y")
                {
                    repeat = 0;
                }
                else
                {
                    repeat = 1;
                }
                design();//end of the code

            }
        }


    }
}
