"use strict";
var __spreadArray = (this && this.__spreadArray) || function (to, from, pack) {
    if (pack || arguments.length === 2) for (var i = 0, l = from.length, ar; i < l; i++) {
        if (ar || !(i in from)) {
            if (!ar) ar = Array.prototype.slice.call(from, 0, i);
            ar[i] = from[i];
        }
    }
    return to.concat(ar || Array.prototype.slice.call(from));
};
Object.defineProperty(exports, "__esModule", { value: true });
/* eslint-disable import/no-anonymous-default-export */
var redux_1 = require("redux");
var urunler_1 = require("../reducers/urunler");
var kategoriler_1 = require("../reducers/kategoriler");
exports.default = (function () {
    var enhancers = [];
    var windowIfDefined = typeof window === 'undefined' ? null : window; // eslint-disable-line @typescript-eslint/no-explicit-any
    if (windowIfDefined && windowIfDefined.__REDUX_DEVTOOLS_EXTENSION__) {
        enhancers.push(windowIfDefined.__REDUX_DEVTOOLS_EXTENSION__());
    }
    var store = redux_1.createStore.apply(void 0, __spreadArray([(0, redux_1.combineReducers)({
            urunler: urunler_1.default,
            kategori: kategoriler_1.default
        })], enhancers, false));
    return store;
});
//# sourceMappingURL=configureStore.js.map