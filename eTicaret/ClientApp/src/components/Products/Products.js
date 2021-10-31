"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var React = require("react");
var SiteHaritasi_1 = require("./SiteHaritasi");
var Filtreleme_1 = require("./Filtreleme");
var ProductKategoriler_1 = require("./ProductKategoriler");
var Filtre_1 = require("./Filtre");
var Marka_1 = require("./Marka");
var Urunler_1 = require("./Urunler");
var Pagination_1 = require("./Pagination");
require("./Products.css");
var Products = function () {
    return (React.createElement("div", { className: "container-fluid", style: { backgroundColor: "rgb(243, 243, 243)", paddingBottom: "25px" } },
        React.createElement(SiteHaritasi_1.default, null),
        React.createElement(Filtreleme_1.default, null),
        React.createElement("div", { className: "container" },
            React.createElement("div", { className: "row" },
                React.createElement(ProductKategoriler_1.default, null),
                React.createElement("div", { className: "col-md-9", id: "filtreIcerik" },
                    React.createElement(Filtre_1.default, null),
                    React.createElement(Marka_1.default, null),
                    React.createElement(Urunler_1.default, null),
                    React.createElement(Pagination_1.default, null))))));
};
exports.default = Products;
//# sourceMappingURL=Products.js.map