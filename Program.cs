using System;
using System.Buffers;
using System.Collections;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;






public class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
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
        const string GuardLore = "Guard: Ho you are the wizard ho robbed one apple, you will be here for other 5 days";
        const string WizardTitle = "Title: ";
        const string WizardTitle1 = "Raoden the Elantrian";
        const string WizardTitle2 = "Zyn the Buguejat";
        const string WizardTitle3 = "Arka Nullpointer";
        const string WizardTitle4 = "Elarion of the Embers";
        const string WizardTitle5 = "ITB-Wizard the Grey";
        const string WizardText1 = ", You repeat in the 2nd call.";
        const string WizardText2 = ", You still confuse the rod with a spoon.";
        const string WizardText3 = ", You are a Summoner of Magic Breezes.";
        const string WizardText4 = ", Wow! You can summon dragons without burning down the lab!";
        const string WizardText5 = ", You have reached the rank of Master of Arcana!.";
        //string menuSubtitle = $"===== Welcome,{realName} the {} with level {} =====";
        // Level 2
        const string DiceOne = "  ________ \n /       /|\n/_______/ |\n|       | |\n|   o   | /\n|       |/\n'-------' ";
        const string DiceTwo = "  ________ \n /       /|\n/_______/ |\n|o      | |\n|       | /\n|     o |/\n'-------' ";
        const string DiceTree = "  ________ \n /       /|\n/_______/ |\n|o      | |\n|   o   | /\n|     o |/\n'-------' ";
        const string DiceFour = "  ________ \n /       /|\n/_______/ |\n| o   o | |\n|       | /\n| o   o |/\n'-------' ";
        const string DiceFive = "  ________ \n /       /|\n/_______/ |\n| o   o | |\n|   o   | /\n| o   o |/\n'-------' ";
        const string DiceSix = "  ________ \n /       /|\n/_______/ |\n| o   o | |\n| o   o | /\n| o   o |/\n'-------' ";
        const string EnemyEncounter = "You have and encounter with: ";
        const string EnemyEncounterHp = ", the hp of the enemy are :";
        const string ActionAttack = "Click a key to hit";
        const string TotalHp = "total hp are: ";
        const string LvlUp = " level up to: ";
        // Level 3 
        const string MineX = "Put a number between 0 to 4 to chose line to mine";
        const string MineY = "Put a number between 0 to 4 to chose column to mine";
        int totalBitcoins = 0;
        //Level 4
        const string InventoryMassage = "In your inventory you have:";
        string[] arrayInventory = new string[0];
        int maxItemps = 0;
        //Level 5


        //Level 6




        //Level 7






        int WizardLvl = 0;






        const string Error = "Input error try again";
        int oP = 0, powerWizard, totalWizard = 0;








        string nameWizard;




        var random = new Random();








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
                    try
                    {
                        nameWizard = Console.ReadLine()!;








                    }
                    catch (NullReferenceException)
                    {
                        Console.WriteLine(GuardRage);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(GuardRage);
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






                        int trainingTime = random.Next(1, 25);




                        powerWizard = random.Next(1, 11);




                        totalWizard += powerWizard;






                        Console.WriteLine($"In Day {i} Wizard has practice for {trainingTime} Hours and gained {powerWizard}, Total: {totalWizard}");






                        if (totalWizard < 20)
                        {
                            Console.WriteLine(WizardTitle + WizardTitle1 + WizardText1);


                        }
                        else if (20 <= totalWizard && totalWizard <= 29)
                        {
                            Console.WriteLine(WizardTitle + WizardTitle2 + WizardText2);
                        }
                        else if (30 <= totalWizard && totalWizard <= 34)
                        {
                            Console.WriteLine(WizardTitle + WizardTitle3 + WizardText3);
                        }
                        else if (35 <= totalWizard && totalWizard <= 39)
                        {
                            Console.WriteLine(WizardTitle + WizardTitle4 + WizardText4);
                        }
                        else
                        {
                            Console.WriteLine(WizardTitle + WizardTitle5 + WizardText5);
                        }
                    }
                    break;




                case 2:
                    string[] ArrayMonster = { "Wandering Skeleton 💀", "Forest Goblin 👹", "Green Slime", "Ember Wolf 🐺", "Giant Spider 🕷️", "Iron Golem 🤖", "Lost Necromancer 🧝‍♂️", "Ancient Dragon 🐉" };
                    int[] ArrayHp = { 3, 5, 10, 11, 18, 15, 20, 50 };




                    int randomEnemy = random.Next(0, 8);
                    Console.WriteLine(EnemyEncounter + ArrayMonster[randomEnemy] + EnemyEncounterHp + ArrayHp[randomEnemy]);


                    int enemyHp = ArrayHp[randomEnemy];



                    int numberDice;
                    do
                    {
                        numberDice = random.Next(1, 7);


                        if (numberDice == 1)
                        {
                            Console.WriteLine(DiceOne);
                            enemyHp -= 1;
                        }
                        else if (numberDice == 2)
                        {
                            Console.WriteLine(DiceTwo);
                            enemyHp -= 2;
                        }
                        else if (numberDice == 3)
                        {
                            Console.WriteLine(DiceTree);
                            enemyHp -= 3;
                        }
                        else if (numberDice == 4)
                        {
                            Console.WriteLine(DiceFour);
                            enemyHp -= 4;
                        }
                        else if (numberDice == 5)
                        {
                            Console.WriteLine(DiceFive);
                            enemyHp -= 5;
                        }
                        else
                        {
                            Console.WriteLine(DiceSix);
                            enemyHp -= 6;
                        }
                        Console.WriteLine(ActionAttack);
                        Console.ReadKey();
                        Console.WriteLine(ArrayMonster[randomEnemy] + TotalHp + enemyHp);
                    }
                    while (enemyHp > 0);


                    if (enemyHp <= 0)
                    {
                        WizardLvl += 1;
                        Console.WriteLine(LvlUp + WizardLvl);
                    }
                    break;
                case 3:


                    int[,] matMine = new int[5, 5];
                    string[,] simbolMine = new string[5, 5];


                    int obtainCoin = random.Next(1, 101);


                    int coinValue = random.Next(5, 51);




                    for (int x = 0; x < 5; x++)
                    {


                        for (int y = 0; y < 5; y++)
                        {
                            simbolMine[x, y] = "➖";
                        }
                    }


                    for (int x = 0; x < 5; x++)
                    {
                        coinValue = random.Next(5, 51);
                        obtainCoin = random.Next(1, 101);
                        for (int y = 0; y < 5; y++)
                        {
                            if (obtainCoin <= 50)
                            {
                                matMine[x, y] = 0;
                            }
                            else
                            {
                                matMine[x, y] = coinValue;
                            }

                        }
                    }
                    int minerTrys = 1;


                    while (minerTrys <= 5)
                    {
                        Console.WriteLine(MineX);
                        int x = int.Parse(Console.ReadLine());


                        Console.WriteLine(MineY);
                        int y = int.Parse(Console.ReadLine());


                        if (matMine[x, y] == 0)
                        {
                            simbolMine[x, y] = "❌";
                        }
                        else
                        {
                            simbolMine[x, y] = "🪙";
                        }
                        minerTrys++;
                        Console.WriteLine("You obtained " + matMine[x, y] + "Bitcoins");
                        totalBitcoins += matMine[x, y];
                        Console.WriteLine("Your total bitcoins are" + totalBitcoins);
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                Console.Write(simbolMine[i, j] + "  ");
                            }
                            Console.WriteLine();
                        }
                    }
                    break;


                case 4:




                    Console.WriteLine(InventoryMassage);
                    for (int i = 0; i < arrayInventory.Length; i++)
                    {
                        Console.WriteLine($"{arrayInventory[i]}");
                    }


                    break;
                case 5:
                    string[] AddToInventory(string[] inventory, string item)
                    {
                        // Crear nuevo array 1 espacio más grande
                        string[] newInventory = new string[arrayInventory.Length + 1];


                        // Copiar todo lo anterior
                        for (int i = 0; i < inventory.Length; i++)
                        {
                            newInventory[i] = inventory[i];
                        }


                        // Añadir el nuevo objeto
                        newInventory[newInventory.Length - 1] = item;


                        return newInventory;
                    }


                    string[] ArrayShop = { "Iron Dagger 🗡️", "Healing Potion ⚗️", "Ancient Key 🗝️", "Crossbow 🏹", "Metal Shield 🛡️" };


                    int[] ArrayPrice = { 30, 10, 50, 40, 20 };


                    int userBuy = 0;
                    for (int i = 0; i < ArrayShop.Length; i++)
                    {


                        Console.Write($"{i}-{ArrayShop[i]}");
                        Console.WriteLine($" The price are {ArrayPrice[i]}");
                    }
                    Console.WriteLine("Put a number between 0 to 4 to buy the object");
                    try
                    {
                        userBuy = int.Parse(Console.ReadLine()!);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine();
                    }


                    if (userBuy >= 0 && userBuy <= 4)
                    {
                        int objectPrice = ArrayPrice[userBuy];




                        if (totalBitcoins >= objectPrice)
                        {
                            totalBitcoins -= objectPrice;
                            arrayInventory = AddToInventory(arrayInventory, ArrayShop[userBuy]);
                        }
                        else
                        {
                            Console.WriteLine($"You need more Bitcoins to buy, you have{totalBitcoins}, money needed{objectPrice}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You put a rong number");
                    }




                    break;
                case 6:






                    break;
                case 7:








                    break;
                default:
                    Console.WriteLine(Error);
                    break;
            }
        } while (oP != 8);
    }
}

