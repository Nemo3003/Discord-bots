using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using System;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;

namespace newBot.Modules
{
    //You can also add separately the commands you want on the bot. To do this,in addition to the main program code, we create a new class that we will call 'Commands'. To add commands so that the bot responds to them, do as I did below.
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("commands")]
        public async Task Comandi()
        {
            await ReplyAsync("/comandi: Show avaible commands" +
                "\n.\n/create log: Create a news channel with the log of the bot" +
                "\n.\n/time: Show date and time" +
                "\n.\n/what game tonight" +
                "\n.\n/which class");
        }

        [Command("time")]
        public async Task Time()
        {
            await ReplyAsync("Now is:\n" + DateTime.Now);
        }
        [Command("what game tonight")]
        public async Task gameTonight()
        {
            string[] words = { "Phasmophobia", "Devour", "L4D2", "Better go to sleep", "Ask Alfred", "Project Zomboid" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(words.Length);
            string selectedWord = words[randomIndex];

            await ReplyAsync("You should play:\n" + selectedWord);
        }
        [Command("which class")]
        public async Task ByuClass()
        {
            string[] classes = { "CIT326", "CIT327", "CIT325", "FAML 160", "CHILD 210", "NUTR 150" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(classes.Length);
            string selectedClass = classes[randomIndex];
            if (selectedClass != "CIT326") {
                await ReplyAsync("I would suggest you first do at least 2 homeworks from CIT326 and then get to:\n" + selectedClass);
             }
            else
            {
                await ReplyAsync("I didn't expected this to happen!:\n" + selectedClass);
            }
        } 
    }
}