const Discord = require("discord.js");
const Commando = require('discord.js-commando')
const userScheme = require('../../../models/userModel')

module.exports = class blacklistCommand extends Commando.Command {
    constructor(client) {
      super(client, {
        name: 'blacklist',
        group: 'administration',
        memberName: 'blacklist',
        aliases: ["bl"],
        userPermissions: ['ADMINISTRATOR'],
        description: 'Blacklists a user', 
        args: [
          {
            key: 'user',
            prompt: 'Who do you want to blacklist',
            type: 'string',
            required: true
          },
      ]     
      })
    }
  
    run = async (message, args) => {
        
        let user = await userScheme.findOne({userName:args.user})
        if(!user) return await message.channel.send("This user is not whitelisted")
        await user.remove().catch(err => {
            message.channel.send(err.stack)
        })
        let messageEmbed = new Discord.MessageEmbed()
                            .setTitle("Succes")
                            .setDescription("Succesfully blacklisted "+args.user)



        await message.channel.send(messageEmbed)

    }

}
