"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var React = require("react");
var OdemeSecenekleri_1 = require("./OdemeSecenekleri");
var AlisverisKredisiSecenekleri_1 = require("./AlisverisKredisiSecenekleri");
var Bilgi_1 = require("./Bilgi");
var AciklamaMetni_1 = require("./AciklamaMetni");
var UrunKategoriKurumsal_1 = require("./UrunKategoriKurumsal");
var HaklariSaklidir_1 = require("./HaklariSaklidir");
var Footer = function () {
    return (React.createElement("footer", null,
        React.createElement("div", { className: "container-fluid", style: { backgroundColor: "white", paddingBottom: "50px" } },
            React.createElement(OdemeSecenekleri_1.default, null),
            React.createElement(AlisverisKredisiSecenekleri_1.default, null),
            React.createElement(Bilgi_1.default, null),
            React.createElement(AciklamaMetni_1.default, null)),
        React.createElement("div", { className: "container-fluid border-bottom", style: { backgroundColor: "#FAFAFA", paddingBottom: "70px" } },
            React.createElement(UrunKategoriKurumsal_1.default, null)),
        React.createElement("div", { className: "container-fluid", style: { backgroundColor: "white" } },
            React.createElement(HaklariSaklidir_1.default, null))));
};
exports.default = Footer;
//# sourceMappingURL=Footer.js.map