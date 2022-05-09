const mongoose = require('mongoose')


const serialModel = new mongoose.Schema({
    GeneratedBy: String,
    serialKey: String,
})

module.exports = mongoose.model("Serial-Keys", serialModel)
