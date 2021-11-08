const express = require("express");
var app = express();
app.use('/assets',express.static(__dirname + '/assets'));

app.get("/", (req,res)=>{
    res.sendFile(__dirname + "/views/index.html");
});

app.get("/login", (req,res)=>{
    res.sendFile(__dirname + "/views/login.html");
});

app.get("/register", (req,res)=>{
    res.sendFile(__dirname + "/views/register.html");
});

app.listen(3001, ()=>{
    console.log("Server running at 3001 🥳");
});