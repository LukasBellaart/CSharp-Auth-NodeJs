const Discord = require("discord.js");
const Commando = require('discord.js-commando')
const serialScheme = require('../../../models/serialModel')
const tokenScheme = require('../../../models/tokenModel')

module.exports = class clearDBCommand extends Commando.Command {
    constructor(client) {
      super(client, {
        name: 'cleardb',
        group: 'administration',
        memberName: 'cleardb',
        aliases: [],
        userPermissions: ['ADMINISTRATOR'],
        description: 'Generates a serial Key',      
      })
    }
  
    run = async (message, args) => {
        await tokenScheme.deleteMany({})
        await serialScheme.deleteMany({})
        let messageEmbed = new Discord.MessageEmbed()
                            .setTitle("Userinfo")
                            .setDescription("Succesfully cleared the DataBase")
        await message.channel.send(messageEmbed)
    }

}
