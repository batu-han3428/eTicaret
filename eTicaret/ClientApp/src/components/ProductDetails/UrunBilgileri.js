"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var React = require("react");
var BirlikteAl_1 = require("./BirlikteAl");
var MarkaStok_1 = require("./MarkaStok");
var SepeteEkle_1 = require("./SepeteEkle");
var TabMenu_1 = require("./TabMenu");
var UrunBaslik_1 = require("./UrunBaslik");
var UrunFiyat_1 = require("./UrunFiyat");
require("./UrunBilgileri.css");
var UrunBilgileri = function () {
    return (React.createElement("div", { className: "col-md-6", id: "urunBilgileriSutun" },
        React.createElement(MarkaStok_1.default, null),
        React.createElement(UrunBaslik_1.default, null),
        React.createElement("div", { className: "row" },
            React.createElement("div", { className: "col-md-12", id: "urunFiyatSepeteEkleSutun" },
                React.createElement(UrunFiyat_1.default, null),
                React.createElement(SepeteEkle_1.default, null))),
        React.createElement(TabMenu_1.default, null),
        React.createElement(BirlikteAl_1.default, null)));
};
exports.default = UrunBilgileri;
//# sourceMappingURL=UrunBilgileri.js.map