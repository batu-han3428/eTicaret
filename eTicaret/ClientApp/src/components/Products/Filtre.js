"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var React = require("react");
var Filtre = function () {
    return (React.createElement("div", { className: "row" },
        React.createElement("div", { className: "col-md-12 p-4", id: "icerikEnUst" },
            React.createElement("div", { className: "me-auto" },
                React.createElement("span", null,
                    React.createElement("b", null, "Telefon"),
                    " i\u00E7in 2308 \u00FCr\u00FCn bulundu")),
            React.createElement("div", { id: "filtreBuyukEkran" },
                React.createElement("select", { defaultValue: '0', className: "form-select form-select-sm p-2" },
                    React.createElement("option", { value: "default", disabled: true }, "Se\u00E7iniz..."),
                    React.createElement("option", { value: "0" }, "En Pop\u00FCler"),
                    React.createElement("option", { value: "1" }, "\u0130sme G\u00F6re (A-Z)"),
                    React.createElement("option", { value: "2" }, "\u0130sme G\u00F6re (Z-A)"),
                    React.createElement("option", { value: "3" }, "Fiyata G\u00F6re (Artan)"),
                    React.createElement("option", { value: "4" }, "Fiyata G\u00F6re (Azalan)"),
                    React.createElement("option", { value: "5" }, "\u0130ndirimli \u00DCr\u00FCnler"))))));
};
exports.default = Filtre;
//# sourceMappingURL=Filtre.js.map