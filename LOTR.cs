using System;
using System.Collections.Generic;
using System.Text;
//have all subsequent classes inherit user input from LOTR class
namespace FinalProjectProofOfConcept
{
    class LOTR
    {
        private string Entered_Date;
        private string Entered_Age;
        private string Entered_Series;

        public LOTR(string entered_Date, string entered_Age, string entered_Series)//creates constructor for private variables
        {
            Entered_Date = entered_Date;
            Entered_Age = entered_Age;
            Entered_Series = entered_Series;//exists here soley for inheritance purposes. May not need to exist here at all
        }
        public string User_Date { get => Entered_Date; set => Entered_Date = value; }//allows use of user input values

        public string User_Series { get => Entered_Series; set => Entered_Series = value; }//allows use of user input values

        public string User_Age { get => Entered_Age; set => Entered_Age = value; }//allows use of user input values

        public void LOTR_Method(string entered_Date,string entered_Age)//Method used to handle LOTR calendar
        {
            int i;
            bool Gandalf_Switch = false;
            bool Check_Switch = false;
            string[] Gandalf_Array = new string[] {"April 12","Gandalf tells Frodo of the ring","June 31","Gandalf leaves for Isengard","July 20","Gandalf imprisoned at Orthanc","September 18","Gandalf escapes Orthanc","September 19","Gandalf comes to Edoras","September 23","Gandalf tames Shadowfax","October 18","Gandalf reaches Rivendell" };
            
            while (Gandalf_Switch == false)
            {
                for (i = 0; i < Gandalf_Array.Length; i++)//iterates through each instance of the gandalf array
                {
                    if (i == Gandalf_Array.Length-1)
                    {
                        Check_Switch = true;

                    }
                    if (entered_Date == Gandalf_Array[i])
                    {
                        Console.WriteLine(Gandalf_Array[i + 1]);
                        Gandalf_Switch = true;
                        break;
                    }
                    else if(Check_Switch==true && entered_Date!=Gandalf_Array[i])//if user date is not within array inform user
                    {
                        Console.WriteLine("To no ones surprise, he wasn't doing anything on that day");
                        Gandalf_Switch = true;
                        break;
                    }
                    
                }
            }


        }
        public void FirstAge_Method(string entered_Date,string entered_Age)//Method used to handle first age calendar
        {
            int j;
            bool FirstAge_Switch=false;
            bool Iteration_Switch=false;
            string[] FirstAge_Array = new string[] {"1","Sun first sets sail;awakening of men in Hildorien","20","Turgon and Finrod establish Gondolin","60","battle of Dagor Aglareb is fought;men cease worship of Illuvatar","116","Gondolin is completed","260","Glaurung is driven to Angband;the long peace begins","305","Men discovered by Finrod","455","Morgoth breaks siege of Angband;Fingolfin killed","457","Minas Tirith falls to Sauron","472","Nirnaeth Arnoediad is fought","495","Battle of Tumhalad and sack of Nargothrond;Tuor comes to Gondolin","505","Doriath destroyed in second kinslaying","510","Gondolin betrayed by Maeglin and sacked","538","Third kinslaying occurs","545","War of Wrath begins","587","Morgoth is cast into the void;remaining silmarils are stolen and lost;elves are summoned to Valinor" };

            while (FirstAge_Switch == false)
            {
                for (j = 0; j < FirstAge_Array.Length; j++)
                {
                    if (j == FirstAge_Array.Length - 1)
                    {
                        Iteration_Switch = true;
                    }

                    if (entered_Date == FirstAge_Array[j])
                    {
                        Console.WriteLine(FirstAge_Array[j + 1]);
                        FirstAge_Switch = true;
                        break;
                    }
                    else if (Iteration_Switch == true && entered_Date != FirstAge_Array[j])
                    {
                        Console.WriteLine("That date is unknown");
                        FirstAge_Switch = true;
                        break;
                    }
                }
            }
        }

        public void SecondAge_Method(string entered_Date,string entered_Age)//Method used to handle second age calendar
        {
            int k;
            bool SecondAge_Switch = false;
            bool Iteration_Switch = false;
            string[] SecondAge_Array = new string[] {"1","Foundation of the Grey Havens","500","Sauron rises again in middle earth","600","Numenorean ships sail to middle earth","750","Noldor found the realm of Eregion","1000","Sauron begins building Barad-dur","1200","Numenoreans build permanent havens in Middle Earth","1350","Galadriel comes to Lorien","1600","The one ring is forged;Barad dur is completed","1693","war of elves and Sauron begins;Elvish rings are hidden","1697","Elrond establishes Rivendell","1700","Sauron's forces retreat to Mordor","1800","Numenor establishes permanent settlements in Middle Earth","2221","Ringwraiths first appear","3209","Birth of Isildur","3262","Sauron taken prisoner","3280","Isildur steals from Nimloth;the White Tree is burned","3300","Sauron becomes high priest of Melkor","3320","Realms of Gondor and Arnor are founded","3428","Sauron beseiges Minis Ithil;War of the Last Alliance begins","3430","The last alliance of elves and men is formed","3434","Siege of Barad-dur begins","3441","Isildur slays Sauron by cutting the one ring from his finger, destroying his physical form and ending the war" };

            while (SecondAge_Switch == false)
            {
                for (k = 0; k < SecondAge_Array.Length; k++)
                {
                    if (k == SecondAge_Array.Length - 1)
                    {
                        Iteration_Switch = true;
                    }
                    if (entered_Date == SecondAge_Array[k])
                    {
                        Console.WriteLine(SecondAge_Array[k + 1]);
                        SecondAge_Switch = true;
                        break;
                    }
                    else if (Iteration_Switch == true && entered_Date != SecondAge_Array[k])
                    {
                        Console.WriteLine("That date is unknown");
                        SecondAge_Switch = true;
                        break;
                    }
                }
            }
        }

        public void ThirdAge_Method(string entered_Date,string entered_Age)
        {
            int L;
            bool ThirdAge_Switch = false;
            bool Iteration_Switch = false;
            string[] ThirdAge_Array = new string[] {"2","Isildur is killed by orcs;The one ring is lost in the Anduin","3","The shards of Narsil are brought to Imladris","1000","The Istari arrive in Middle Earth","1050","Gondor reaches the height of its power;Sauron inhabits Dol Goldur","1300","The shadow over Middle earth grows;The realm of Angmar is formed;The Nazgul reappear","1601","Hobbits settle the Shire","1975","Gondor destroys Angmar","1980","Durin's Bane awoken in Moria;The Witch king returns to Mordor","2002","Minis Ithil falls","2050","The line of kings fails","2063","The watchful peace begins","2430","Gollum is born","2463","Gollum claims the ring","2746","Thorin Oakenshield is born","2770","Smaug claims Erebor","2890","Bilbo Baggins is born","2941","Bilbo Baggins claims the one ring;Sauron is driven to Mordor from Dol Goldur","2951","Sauron declares his presence in Mordor","2953","Last meeting of the white council","2968","Frodo Baggins is born","3002","Bilbo settles in Rivendell","3018","Council of Elrond is held, the fellowship sets out","3019","Gandalf dies fighting a balrog;The fellowship dissolves;The battles of the war of the ring occur;The one ring is destroyed","3021","Elrond,Galadriel,Gandalf,Frodo,and Bilbo depart for the Grey Havens" };

            while (ThirdAge_Switch == false)
            {
                for (L = 0; L < ThirdAge_Array.Length; L++)
                {
                    if (L == ThirdAge_Array.Length - 1)
                    {
                        Iteration_Switch = true;
                    }
                    if(entered_Date == ThirdAge_Array[L])
                    {
                        Console.WriteLine(ThirdAge_Array[L + 1]);
                        ThirdAge_Switch = true;
                        break;
                    }
                    else if (Iteration_Switch == true && entered_Date != ThirdAge_Array[L])
                    {
                        Console.WriteLine("That date is unknown");
                        ThirdAge_Switch = true;
                        break;
                    }
                }
            }
        }
    }
}
