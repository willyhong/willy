var score = 0
$("[class^='cir']").click(function(){
  let add =  $(this).attr('data-label')
  console.log(add)
  score += parseInt(add*10)
  updateGame()
})

$(window).keydown(function(evt){
  console.log(evt.key)
  if (evt.key=="r"){
    resetGame()
  }
  if (evt.key=="k"){
    $(".target").toggleClass("moving")
  }
})

function updateGame(){
  $(".score").text("Score: "+score)
}

function resetGame(){
  score=0
  updateGame()
  $(".target").removeClass("moving")
  $(".spot").remove()
  
}

$(window).mousemove(function(evt){
  $(".mouseText").text(`(${evt.pageX},${evt.pageY})`)
  $(".mouseSymbol")
    .css("left",evt.pageX+"px")
    .css("top",evt.pageY+"px")
})


$(".target").click(function(evt){
  var spot = $("<div class=spot></div>")
  spot.css("left",evt.pageX - $(this).offset().left+"px")
      .css("top",evt.pageY - $(this).offset().top+"px")
  $(this).append(spot)
  console.log(spot)
})