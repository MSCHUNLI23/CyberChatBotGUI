using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace CyberChatBotGUI
{
    public class user_name
    {
        public string submit_name(TextBox user_name, ListView chats)
        {
            //temp variables
            string filename = "user_names.txt";

            //check if the filename exists or not , then auto create
            if (!File.Exists(filename))
            {
                //auto create the file using AppendAllText() function
                File.AppendAllText(filename, "auto_create\n");
            }

            //temp variables
            string name = user_name.Text.ToString();
            bool found = check_name(name);

            //check if the user is found or not and write the name in a text file
            if (!found)
            {
                //write the name in a text file
                File.AppendAllText(filename, name + "\n");
                //then welcome the user
                error_method("ChatBot", "Hey " + name + " welcome to AI cybersecurity", chats);
            }
            else
            {
                //welcome the user back
                error_method("ChatBot", "Hey " + name + " welcome back, how can i help you today", chats);
            }

            //return name
            return name;
        }

        //method to check name of the user
        private bool check_name(string name)
        {
            //temp variable
            string filename = "user_names.txt";
            bool found_name = false;

            //check if file exists before reading
            if (File.Exists(filename))
            {
                //store or get all the names in the text file and store in an 1D array
                string[] names = File.ReadAllLines(filename);

                //foreach to search the name of the user
                foreach (string name_found in names)
                {
                    //if statement to check for the username
                    if (name_found.ToLower() == name.ToLower())
                    {
                        //found_name set to true
                        found_name = true;
                    }
                }
            }

            //return the status of found or not [ true or false ]
            return found_name;
        }

        //error method - displays messages in the chat ListView
        private void error_method(string sender, string message, ListView chats)
        {
            // Add the message to the ListView
            chats.Items.Add(sender + ": " + message);
        }
    }
}
