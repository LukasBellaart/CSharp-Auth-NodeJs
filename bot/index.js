const Commando = require('discord.js-commando');
const path = require('path')
const client = new Commando.Client({
    owner: 'ownerId',
    commandPrefix: '-',
    unknownCommandResponse: false

});

client.once('ready', () => {
    console.log("Bot is online")
    client.registry
      .registerGroups([
        ['administration', 'Administrative commands'],


      ])
      .registerDefaults()
      .registerCommandsIn(path.join(__dirname, 'commands'))
})


client.login("BotToken")
