"use strict";
var __assign = (this && this.__assign) || function () {
    __assign = Object.assign || function(t) {
        for (var s, i = 1, n = arguments.length; i < n; i++) {
            s = arguments[i];
            for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p))
                t[p] = s[p];
        }
        return t;
    };
    return __assign.apply(this, arguments);
};
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
var urunState = [];
var urunReducer = function (state, action) {
    if (state === void 0) { state = urunState; }
    console.log(action);
    switch (action.type) {
        case "ADD_BLOG":
            return __spreadArray(__spreadArray([], state, true), [
                action.blog //diziye yeni eleman ekledik
            ], false);
        case "REMOVE_BLOG":
            return state.filter(function (_a) {
                var id = _a.id;
                return id !== action.id;
            });
        case "EDIT_BLOG":
            return state.map(function (blog) {
                if (blog.id === action.id) {
                    return __assign(__assign({}, blog), action.updates);
                }
                else {
                    return blog;
                }
            });
        case "LİST_PRODUCTS":
            return [
                action.location
            ];
        default:
            return state;
    }
};
exports.default = urunReducer;
//# sourceMappingURL=urunler.js.map