const mongoose = require('mongoose')


const tokenModel = new mongoose.Schema({
    GeneratedBy: String,
    availableFor: String
})

module.exports = mongoose.model("Tokens", tokenModel)
