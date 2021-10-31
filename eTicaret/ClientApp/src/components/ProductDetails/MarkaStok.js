"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var React = require("react");
var Icon = require("react-bootstrap-icons");
var MarkaStok = function () {
    return (React.createElement("div", { className: "row" },
        React.createElement("div", { className: "col-md-12", id: "markaStokSutun" },
            React.createElement("div", { id: "MarkaAlan" },
                React.createElement("img", { id: "Marka", src: require('./MarkaStokImg/8885287551026.png'), alt: "xiomilogo" })),
            React.createElement("div", { id: "stokAlan" },
                React.createElement("div", { id: "stokIconAlan" },
                    React.createElement(Icon.CheckLg, { id: "stokIcon" })),
                React.createElement("div", { id: "stokYaziAlan" },
                    React.createElement("span", { id: "stokYazi" }, "Stokta Var"))))));
};
exports.default = MarkaStok;
//# sourceMappingURL=MarkaStok.js.map