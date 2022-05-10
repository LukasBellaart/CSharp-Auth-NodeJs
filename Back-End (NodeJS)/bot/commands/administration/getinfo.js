const Discord = require("discord.js");
const Commando = require('discord.js-commando')
const userScheme = require('../../../models/userModel')

module.exports = class getInfoCommand extends Commando.Command {
    constructor(client) {
      super(client, {
        name: 'getinfo',
        group: 'administration',
        memberName: 'getinfo',
        aliases: [],
        userPermissions: ['ADMINISTRATOR'],
        description: 'Gets the users info', 
        args: [
          {
            key: 'user',
            prompt: 'What person do you want information from?',
            type: 'user'
          },
      ]     
      })
    }
  
    run = async (message, args) => {
        
        let user = await userScheme.findOne({discordId:args.user.id})
        if(!user) return await message.channel.send("This user is not whitelisted")
        let messageEmbed = new Discord.MessageEmbed()
                            .setTitle("Userinfo")
                            .addField("Username", user.userName, false)
                            .addField("Discord Id", user.discordId, false)
                            .addField("Serial-Key", user.serialKey, false)



        await message.channel.send(messageEmbed)

    }

}
