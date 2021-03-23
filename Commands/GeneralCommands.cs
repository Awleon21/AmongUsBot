using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using static Constants.Channels;

namespace Commands 
{
    public class GeneralCommands 
    {
        [Command("Invite")]
        public async Task Invite(CommandContext iCommandContext)
        {
            await iCommandContext.TriggerTypingAsync();

            var embed = new DiscordEmbedBuilder
            {
                Title = "Discord invite link",
                Url = "https://discord.gg/BQuG2xm",
                Color = DiscordColor.DarkGreen,
                Description = $"Don't forget to welcome our new friends {Environment.NewLine} https://discord.gg/BQuG2xm "
            };

            await iCommandContext.RespondAsync("", embed: embed);
        }    

    }
}
