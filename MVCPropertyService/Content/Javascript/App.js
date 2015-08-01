var main = function () {
  $('.main-slide').click(function () {

    var currentSlide = $('.main-slide');
    var nextSlide = currentSlide.next();


    if (nextSlide.length === 0) {
      nextSlide = $('.slide').first();

    }

    currentSlide.fadeOut(600).removeClass('active-slide');
    nextSlide.fadeIn(600).addClass('active-slide');
  });

  $('.second-slide').click(function () {
    var currentSlide = $('.second-slide');
    var prevSlide = currentSlide.prev();


    if (prevSlide.length === 0) {
      prevSlide = $('.slide').last();
    }

    currentSlide.fadeOut(600).removeClass('active-slide');
    prevSlide.fadeIn(600).addClass('active-slide');
  });

};

