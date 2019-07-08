sfunction Circular(startPlayer, startIntex) {
    if (startPlayer == 1) {
        this.arr = [1,2,2,1];
    }
    else {
        this.arr = [2,1,1,2];
    }

   this.currentIndex = startIntex || 0;
}

Circular.prototype.next = function () {
    var i = this.currentIndex, arr = this.arr;
    this.currentIndex = i < arr.length - 1 ? i + 1 : 0;
    return this.current();
}

Circular.prototype.prev = function () {
    var i = this.currentIndex, arr = this.arr;
    this.currentIndex = i > 0 ? i - 1 : arr.length - 1;
    return this.current();
}

Circular.prototype.current = function () {
    return this.arr[this.currentIndex];
}