var Vendor = /** @class */ (function () {
    function Vendor(name) {
        this.name = name;
    }
    Vendor.prototype.greet = function () {
        return "Hello, welcome to " + this.name;
    };
    return Vendor;
}());
