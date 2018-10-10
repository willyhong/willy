var percent = 0
//replace web html
function eatCount (){
   $(".monsterText").html("We are<br>SQUARE<br>MONSTER!")
}
//進度條調整計時器
var timer = setInterval(function(){
  $(".bar").css("width",percent+"%")
  percent+=1
  if(percent>100){
     $(".pageLoading").addClass("complete")
    clearInterval(timer)
    setTimeout(eatCount,3000)
    
  }
},30)