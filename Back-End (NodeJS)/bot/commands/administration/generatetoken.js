const Discord = require("discord.js");
const Commando = require('discord.js-commando')
const tokenScheme = require('../../../models/tokenModel')

module.exports = class generateTokenCommand extends Commando.Command {
    constructor(client) {
      super(client, {
        name: 'generatetoken',
        group: 'administration',
        memberName: 'generatetoken',
        aliases: ["gentoken"],
        userPermissions: ['ADMINISTRATOR'],
        description: 'Generates a token used to reset passwords',      
        args: [
            {
              key: 'user',
              prompt: 'What is the username of the person who you\'re assigning this token to?',
              type: 'string',
              required: true
            },
        ]
      })
    }
  
    run = async (message, args) => {

        const hasPerms = await tokenScheme.findOne({availableFor:args.user})
    
        if(hasPerms) return await message.author.send("User already has permission to change password")


        const tokenDB = await new tokenScheme({
            GeneratedBy: message.author.id,
            availableFor: args.user
        })
    
        await tokenDB.save().catch((err) => {
                console.log(err)
        })
        let messageEmbed = new Discord.MessageEmbed()
        .setTitle("Userinfo")
        .setDescription("User can now change password")
        return await message.author.send(messageEmbed)
    }

}

