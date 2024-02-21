///slider
var swiper = new Swiper(".mySwiper", {
    spaceBetween: 30,
    navigation: {
        nextEl: ".swiper-button-next",
        prevEl: ".swiper-button-prev",
    },
    pagination: {
        el: ".swiper-pagination",
    },
    mousewheel: true,
    keyboard: true,
});
//////////////////////////DZ1
const gmailInput = document.querySelector('#gmail_input')
const gmailButton = document.querySelector('#gmail_button')
const gmailSpan = document.querySelector('#gmail_result')

const EMAIL_REGEXP =/^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;

gmailButton.addEventListener('click',()=>{
    if(EMAIL_REGEXP.test(gmailInput.value)){
        gmailSpan.innerHTML ='OK'
        gmailSpan.computedStyleMap.color ='green'
    }else{
        gmailSpan.innerHTML ='NOT OK'
        gmailSpan.computedStyleMap.color ='red'
    }
})

//////////////////////////DZ2
const moveChaildBlock  = document.querySelector('.child_block')
let numX =0
let numY =0
const animation = () => {
    if (numX <1700 && numY <= 0) {
        numX++
        moveChaildBlock .style.left = `${numX}px`
        setTimeout(animation, 1)
    }else if (numX >=1700&& numY < 800) {
        numY++
        moveChaildBlock .style.top = `${numY}px`
        setTimeout(animation, 1)
    }else if (numX > 0 && numY >= 800) {   ////////////////////ПРОДОЛЖЕНИЕ
        numX--
        moveChaildBlock .style.left =`${numX}px`
        setTimeout(animation,10)
    }else if (numX >= 0 && numY > 0) {
        numY--
        moveChaildBlock .style.top =`${numY}px`
        setTimeout(animation,10)
    }
}
animation()
////////////////////////////////////THE END

//////////////////////////СЕКУНДАМЕР 
let secondsS = document.getElementById('secondsS')
let start = document.getElementById('start')
let stop = document.getElementById('stop')
let reset = document.getElementById('reset')

let time = 0

function sec() {
  time++;
  secondsS.textContent = `${time.toString().padStart(1, '0')}`
}

start.addEventListener('click', () => {
  interval = setInterval(sec, 1000)
  start.disabled = true
  stop.disabled = false
  reset.disabled = false
})

stop.addEventListener('click', () => {
  clearInterval(interval)
  start.disabled = false
  stop.disabled = true
});
reset.addEventListener('click', () => {
    clearInterval(interval)
    time = 0
    secondsS.textContent = '0';
    start.disabled = false
    stop.disabled = true
    reset.disabled = true
})
//////////////////////////////////////THE END


