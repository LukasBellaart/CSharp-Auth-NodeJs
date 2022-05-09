const mongoose = require('mongoose')


const userSchema = new mongoose.Schema({
    userName: String,
    passWord: String,
    discordId: String,
    serialKey: String,
    hwid: String,
})

module.exports = mongoose.model("Users", userSchema)
