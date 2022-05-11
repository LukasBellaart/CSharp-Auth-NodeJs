require('dotenv').config()

const express = require('express')
const mongoose = require('mongoose')
const userSchema = require('./models/userModel')
const serialSchema = require('./models/serialModel')
const tokenScheme = require('./models/tokenModel')
const app = express()
const crypto = require('crypto')
const discord = require('discord.js')
const bodyParser = require('body-parser');

app.use(bodyParser.json());

app.use(bodyParser.urlencoded({ extended: true }));

mongoose.connect(process.env.mongoDbUrl, { useNewUrlParser: true, useUnifiedTopology: true });

mongoose.connection.on('connected', () => {
    console.log("Connected to DB")
});

mongoose.connection.on('err', err => {
    console.log(`Mongoose connection error : \\n ${err.stack}`)
});

mongoose.connection.on('disconnected', err => {
    console.log(`Connection to the database lost`)
});

app.post('/signIn', async(req,res) => {
    if(!req.query.ray) return res.send('Invalid request!')
    if(!req.body.userName) return res.send('No username provided!')
    if(!req.body.passWord) return res.send('No password provided!')

    let userFile = await userSchema.findOne({userName:req.body.userName})
    
    if(!userFile) return res.send('That account does not exist!')

    var sha256 = crypto.createHash("sha256");
    sha256.update(req.body.passWord + process.env.hashKey, "utf8");
    var hashedPassword = sha256.digest("base64");

    if(userFile.passWord != hashedPassword) return res.send('That password is incorrect!')

    var sha256 = crypto.createHash("sha256");
    sha256.update(req.body.passWord + req.query.ray + process.env.hashKey, "utf8");
    var hashedReturn = sha256.digest("base64");
    
    res.send(hashedReturn) 

})

app.post('/changePassword', async(req,res) => {
    if(!req.query.ray) return res.send('Invalid request!')
    if(!req.body.userName) return res.send('No username provided!')
    if(!req.body.newPassword) return res.send('No passWord provided!')
    if(!req.body.repeatPassword) return res.send('No password provided!')


    if(req.body.newPassword.length < 7 || req.body.newPassword.length > 100) return res.send('Passwords can be 7 to 100 characters long.') 


    if(req.body.newPassword != req.body.repeatPassword) return res.send('Entered Passwords are not the same!')

    let userFile = await userSchema.findOne({userName:req.body.userName})
    
    if(!userFile) return res.send('That account does not exist!')


    let hasToken = await tokenScheme.findOne({availableFor:req.body.userName})
    if(!hasToken) return res.send('You do not have the permission to change your password!')

    var sha256 = crypto.createHash("sha256");
    sha256.update(req.body.newPassword + process.env.hashKey, "utf8");
    var hashedPassword = sha256.digest("base64");

    userFile.passWord = hashedPassword

    await userFile.save()

    var sha256 = crypto.createHash("sha256");
    sha256.update(req.body.newPassword + req.query.ray + process.env.hashKey, "utf8");
    var hashedReturn = sha256.digest("base64");

    res.send(hashedReturn) 

    await hasToken.remove()

})

app.post("/createAccount", async(req,res) => {
    if(!req.query.ray) return res.send('Invalid request!')
    if(!req.body.userName) return res.send('No username provided!')
    if(!req.body.passWord) return res.send('No password provided!')
    if(!req.body.discordId) return res.send('No discord id provided!')
    if(!req.body.serialKey) return res.send('No serial key provided!')

    if(req.body.userName.length < 3 || req.body.userName.length > 20) return res.send('Usernames can be 3 to 20 characters long.')
    if(req.body.passWord.length < 7 || req.body.passWord.length > 100) return res.send('Passwords can be 7 to 100 characters long.') 

    let isUsernameTaken = await userSchema.findOne({userName:req.body.userName})
    
    if(isUsernameTaken) return res.send('That username is already taken.')

    let isDiscordIdUsed = await userSchema.findOne({discordId:req.body.discordId})
    
    if(isDiscordIdUsed) return res.send('There is already an account registered to that Discord ID.')

    let isSerialKeyTaken = await userSchema.findOne({serialKey:req.body.serialKey})

    if(isSerialKeyTaken) return res.send('That serial Key has already been used.')

    let doesSerialKeyExist = await serialSchema.findOne({serialKey:req.body.serialKey})

    if(!doesSerialKeyExist) return res.send('That serial Key does not exist.')

    await doesSerialKeyExist.remove()

    var sha256 = crypto.createHash("sha256");
    sha256.update(req.body.passWord + process.env.hashKey, "utf8");
    var hashedPassword = sha256.digest("base64");

    let finalDataBaseProduct = new userSchema({
        userName: req.body.userName,
        passWord: hashedPassword,
        discordId: req.body.discordId,
        serialKey: req.body.serialKey
    })

    await finalDataBaseProduct.save().catch((err) => {
        console.log(err)
    })

    var sha256 = crypto.createHash("sha256");
    sha256.update(req.body.passWord + req.query.ray + process.env.hashKey, "utf8");//utf8 here
    var hashedReturn = sha256.digest("base64");

    res.send(hashedReturn) 
})

app.listen(4200)

require('./bot')