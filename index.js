var players = 0;
var npcs = 0;
var economy = 0;
var credits = 0;
var trade_deals = 0;
var shops_npc = 0;
var shops_player = 0;
// All vars are above.


$(function () {
  $('[data-toggle="popover"]').popover()
   html: true
});

$(function () {
  $('[data-toggle="popover1"]').popover()
  	 html: true
   $("#pop1").attr("data-content", "Population"+' '+npcs);
});
