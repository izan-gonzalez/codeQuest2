using System;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;




public class Program
{
    static void Main()
    {
        const string MenuTitle = "===== MAIN MENU - CODEQUEST =====";
        const string MenuOption1 = "1. Train your wizard";
        const string MenuOption2 = "2. Check the dungeon";
        const string MenuOption3 = "3. Loot the mine";
        const string MenuOption4 = "4. Show inventory";
        const string MenuOption5 = "5. Buy items";
        const string MenuOption6 = "6. Show attacks by LVL";
        const string MenuOption7 = "7. Decode ancint Scroll";
        const string MenuOptionExit = "8. Exit game";
        const string MenuPrompt = "Choose an option (1-7) - (8) to exit: ";
        const string InputErrorMessage = "Invalid input. Please enter a number between 1 and 8.";
        // Level 1
        const string GuardAsk = "Guard: Whats your name Wizard?";
        const string GuardRage = "Guard: THAT NAME IS NOT ON THE LIST!, TELL ME YOUR REAL NAME!!";
        const string EspecificationName = "The name must have 1 capital letter and rest in lower case";
        const string GuardLore = "Guard: Ho you are the wizard ho robbed one apple, you will be here for other 5 days";
        const string WizardTitle1 = "Raoden the Elantrian";
        const string WizardTitle2 = "Zyn the Buguejat";
        const string WizardTitle3 = "Arka Nullpointer";
        const string WizardTitle4 = "Elarion of the Embers";
        const string WizardTitle5 = "ITB-Wizard the Grey";
        //string menuSubtitle = $"===== Welcome,{realName} the {} with level {} =====";


        const string Error = "Input error try again";
        int oP = 0, powerWizard, totalWizard = 0;


        string nameWizard;




        do
        {
            Console.WriteLine(MenuTitle);
            Console.WriteLine(MenuOption1);
            Console.WriteLine(MenuOption2);
            Console.WriteLine(MenuOption3);
            Console.WriteLine(MenuOption4);
            Console.WriteLine(MenuOption5);
            Console.WriteLine(MenuOption6);
            Console.WriteLine(MenuOption7);
            Console.WriteLine(MenuOptionExit);
            Console.Write(MenuPrompt);





            try
            {
                oP = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine(InputErrorMessage);
            }
            catch (Exception)
            {
                Console.WriteLine(InputErrorMessage);
            }


            switch (oP)
            {
                case 1:
                    totalWizard = 0;


                    Console.Write(GuardAsk);
                    Console.WriteLine(EspecificationName);
                    try
                    {
                        nameWizard = Console.ReadLine()!;


                    }
                    catch (NullReferenceException)
                    {
                        Console.WriteLine(GuardRage);
                        Console.WriteLine(EspecificationName+"!!");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(GuardRage);
                        Console.WriteLine(EspecificationName + "!!");
                    }


                    nameWizard = Console.ReadLine()!;


                    string upperName = nameWizard.ToUpper();


                    string firtsLetter = upperName.Remove(1);


                    string nameCreato = nameWizard.Substring(1);


                    string realName = firtsLetter.Insert(1, nameCreato);


                    Console.WriteLine(GuardLore);
                    Console.WriteLine("Your mind: I will meditate for that time.");
                    

                    for (int i = 1; i <= 5; i++)
                    {
                        Console.WriteLine("==============================");


                        var random = new Random();




                        int trainingTime = random.Next(1, 25);


                        powerWizard = random.Next(1, 11);


                        totalWizard += powerWizard;




                        Console.WriteLine($"In Day {i} Wizard has practice for {trainingTime} Hours and gained {powerWizard}, Total: {totalWizard}");




                        if (totalWizard < 20)
                        {
                            Console.WriteLine($"Title:{WizardTitle1}, You repeat in the 2nd call.");
                
                        }
                        else if ( 20<= totalWizard && totalWizard <= 29)
                        {
                            Console.WriteLine($"Title:{WizardTitle2}, You still confuse the rod with a spoon.");
                        }
                        else if (30 <= totalWizard && totalWizard <=34)
                        {
                            Console.WriteLine($"Title:{WizardTitle3},You are a Summoner of Magic Breezes.");
                        }
                        else if (35 <= totalWizard && totalWizard <=39)
                        {
                            Console.WriteLine($"Title:{WizardTitle4},Wow! You can summon dragons without burning down the lab!");
                        }
                        else 
                        {
                            Console.WriteLine($"Title:{WizardTitle5},You have reached the rank of Master of Arcana!.");
                        }
                    }
                    break;

                case 2:

                    break;
                case 3:

                    
                 break;


                case 4:


                case 5:


                case 6: 
                
                
                
                case 7:


                default:


                    Console.WriteLine(Error);


                    break;
            }




        } while (oP != 8);
    }
}