var express = require('express');
var request = require('request');
var router = express.Router();

/* GET home page. */
router.get('/', function (req, res) {
	res.render('index', { title: 'Express' });
});

router.get('/steam', function (req, res) {
    friends();
});

function friends() {
    request.get(
        'http://api.steampowered.com/ISteamUser/GetFriendList/v0001/?key=9E9964DCD224DA403FF5EDE77865C6D5&steamid=76561197981045695',
        function (error, response, body) {
            var frindlist = 0;
            var obj = JSON.parse(body)
            for (var friend in obj.friendslist.friends) {
                var id = obj.friendslist.friends[friend].steamid;
                games(id, function (userID) {
                    frindlist = frindlist + 1;
                    console.log("User: " + userID + " own 'Counter Strike'");
                });
            }
            console.log("Total friends: " + frindlist);
        }
    );
}


function games(id, callback){
    request.get(
        'http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key=9E9964DCD224DA403FF5EDE77865C6D5&steamid=' + id + '&format=json',
        function (error, response, body) {
            var obj = JSON.parse(body);
            for (var game in obj.response.games) {
                if (obj.response.games[game].appid == "730") {
                    callback(id);
                }
            }
        }
    );
}


module.exports = router;

