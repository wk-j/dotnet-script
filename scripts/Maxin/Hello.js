// This example may be contrived.
// It's an attempt to clean up the previous, broken example.
var Halfling = function (fName, lName) {
    this.firstName = fName;
    this.lastName = lName;
}

var NameMixin = {
    fullName: function () {
        return this.firstName + ' ' + this.lastName;
    },
    rename: function (first, last) {
        this.firstName = first;
        this.lastName = last;
        return this;
    }
};

var sam = new Halfling('Sam', 'Lowry');
var frodo = new Halfling('Freeda', 'Baggs');

// Mixin the other methods
_.extend(Halfling.prototype, NameMixin);

// Now the Halfling objects have access to the NameMixin methods
sam.rename('Samwise', 'Gamgee');
frodo.rename('Frodo', 'Baggins');
