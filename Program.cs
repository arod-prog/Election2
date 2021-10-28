/*
Arthor: Andrew Rodriguez
Date: 10/26/2021
Description: Election2, a Kattis 2.7.
             Goal is take an algorthm that track canidates
             there party and then can tally votes to determine
             which Canidate is the winner and print out his/her party
*/

using System;
using System.Collections.Generic;
// This .NET Framework componet helps short the data
using System.Linq;

namespace Election2
{
    class Program
    {
        // Here we created a dictionary, associated the values with each other
        private static Dictionary<string, string> canidateParty;

        static void Main()
        {

            {
                // Names the Dict Canidate party
                canidateParty = new Dictionary<string, string>();

                //Takes user input
                string input = Console.ReadLine();

                // This number is the number of Canidates this case
                decimal canidateNum = decimal.Parse(input);

                // creates a counter that will take a canidate
                // and then a there party on the next line
                // the counter then stops when the inital input is reached 
                int counter = 1;
                while (canidateNum >= counter)
                {
                    string canidate = Console.ReadLine();
                    string party = Console.ReadLine();

                    // This addes the acindate and party to the dictionary
                    canidateParty.Add(canidate, party);
                    counter++;

                }


            }
            // creates a list that holds all the 'votes'        
            List<string> allVotes = new List<string>();

            // the input is the number of votes
            string votess = Console.ReadLine();
            decimal voteNum = decimal.Parse(votess);
            int counterTwo = 1;

            // a counter that stops the code when the 
            // input number is hit
            while (voteNum >= counterTwo)
            {
                // this take the vote
                string voteType = Console.ReadLine();

                // this adds the vote to the list
                allVotes.Add(voteType);
                counterTwo++;


            }
            // this function sorts the votes

            var most = (from i in allVotes
                        where i != null
                        // this groups the same votes together
                        group i by i into grp
                        // this counts the votes and sorts in descending order
                        orderby grp.Count() descending
                        // this selets vote that appears the most, makes it = to 'most'
                        select grp.Key).First();


            // this prints out the key pair for
            // most which is then prints out the party
            // whose canidate recived the most votes
            Console.WriteLine(canidateParty[most]);
        }




    }
}
