const Discord = require("discord.js");
const Commando = require('discord.js-commando')
const serialScheme = require('../../../models/serialModel')

module.exports = class generateKeyCommand extends Commando.Command {
    constructor(client) {
      super(client, {
        name: 'generatekey',
        group: 'administration',
        memberName: 'generatekey',
        aliases: ["genkey"],
        userPermissions: ['ADMINISTRATOR'],
        description: 'Generates a serial Key',      
      })
    }
  
    run = async (message, args) => {
        
        let newSerialKey = await generateProductKey()
        let doesSerialKeyExist = await serialScheme.findOne({serialKey:newSerialKey})
        if(doesSerialKeyExist){
            newSerialKey = await generateProductKey()
        }
    
        const serialDB = await new serialScheme({
            GeneratedBy: message.author.id,
            serialKey: newSerialKey
        })
    
        await serialDB.save().catch((err) => {
                console.log(err)
        })

        let messageEmbed = new Discord.MessageEmbed()
        .setTitle("Userinfo")
        .setDescription(newSerialKey)
        return await message.author.send(messageEmbed)
    }

}

   
function generateProductKey() {
    var tokens = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789",
        chars = 7,
        segments = 7,
        keyString = "";
        
    for( var i = 0; i < segments; i++ ) {
        var segment = "";
        
        for( var j = 0; j < chars; j++ ) {
            var k = getRandomInt( 0, 35 );
            segment += tokens[ k ];
        }
        
        keyString += segment;
        
        if( i < ( segments - 1 ) ) {
            keyString += "-";
        }
    }
    
    return keyString;
}
function getRandomInt( min, max ) {
    return Math.floor( Math.random() * ( max - min + 1 ) ) + min;
}