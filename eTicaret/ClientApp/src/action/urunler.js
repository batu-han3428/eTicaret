"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.listProducts = exports.editProduct = exports.removeProduct = exports.addProduct = void 0;
var addProduct = function (_a) {
    var _b = _a.title, title = _b === void 0 ? '' : _b, _c = _a.description, description = _c === void 0 ? '' : _c, _d = _a.dateAdded, dateAdded = _d === void 0 ? 0 : _d;
    return ({
        type: "ADD_PRODUCT",
        urun: {
            title: title,
            description: description,
            dateAdded: dateAdded
        }
    });
};
exports.addProduct = addProduct;
var removeProduct = function (_a) {
    var id = _a.id;
    return ({
        type: "REMOVE_PRODUCT",
        id: id
    });
};
exports.removeProduct = removeProduct;
var editProduct = function (id, updates) { return ({
    type: "EDIT_PRODUCT",
    id: id,
    updates: updates
}); };
exports.editProduct = editProduct;
var listProducts = function (_a) {
    var location = _a.location;
    return ({
        type: "LİST_PRODUCTS",
        location: location
    });
};
exports.listProducts = listProducts;
//# sourceMappingURL=urunler.js.map