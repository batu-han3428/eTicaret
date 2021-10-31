"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var React = require("react");
var Icon = require("react-bootstrap-icons");
require("./TabMenuJs.js");
var TabMenu = function () {
    return (React.createElement("div", { className: "row" },
        React.createElement("div", { className: "col-md-12", id: "tabMenuSutun" },
            React.createElement("ul", { id: "TabMenu" },
                React.createElement("li", { id: "tab1", className: "tabMenuItem" },
                    React.createElement("a", { className: "tabMenuLink" },
                        React.createElement("div", { className: "tabMenuLinkIconAlan" },
                            React.createElement(Icon.Truck, { className: "tabMenuLinkIcon" })),
                        React.createElement("div", { className: "tabMenuLinkYaziAlan" },
                            React.createElement("span", { className: "tabMenuLinkYazi" }, "Ayn\u0131 G\u00FCn Teslimat")))),
                React.createElement("li", { className: "tabMenuItem", id: "tab2" },
                    React.createElement("a", { className: "tabMenuLink" },
                        React.createElement("div", { className: "tabMenuLinkIconAlan" },
                            React.createElement(Icon.ArrowRepeat, { className: "tabMenuLinkIcon" })),
                        React.createElement("div", { className: "tabMenuLinkYaziAlan" },
                            React.createElement("span", { className: "tabMenuLinkYazi" }, "Kolay \u0130ade")))),
                React.createElement("li", { className: "tabMenuItem", id: "tab3" },
                    React.createElement("a", { className: "tabMenuLink" },
                        React.createElement("div", { className: "tabMenuLinkIconAlan" },
                            React.createElement(Icon.HourglassSplit, { className: "tabMenuLinkIcon" })),
                        React.createElement("div", { className: "tabMenuLinkYaziAlan" },
                            React.createElement("span", { className: "tabMenuLinkYazi" }, "Kargo S\u00FCresi"))))),
            React.createElement("div", { id: "tabMenuIcerikler" },
                React.createElement("div", { className: "tabMenuIcerik", id: "tab1icerik" },
                    React.createElement("span", { className: "tabMenuYazi" },
                        React.createElement(Icon.CheckLg, { className: "tabMenuIcon" }),
                        " \u201CAYNI G\u00DCN TESL\u0130MAT\u201D teslimat ad\u0131m\u0131nda Bug\u00FCn! Sizde teslimat se\u00E7ene\u011Fi olan \u00FCr\u00FCnlerde 12:00\u2019a kadar verilen sipari\u015Flerde ge\u00E7erlidir.")),
                React.createElement("div", { className: "tabMenuIcerik", id: "tab2icerik" },
                    React.createElement("span", { className: "tabMenuYazi" },
                        React.createElement(Icon.CheckLg, { className: "tabMenuIcon" }),
                        " Teslim tarihinden itibaren 21 g\u00FCn i\u00E7erisinde \u00FCr\u00FCn\u00FCn\u00FCz\u00FC isterseniz anla\u015Fmal\u0131 kargo firmalar\u0131 ile depomuza \u00FCcretsiz g\u00F6nderebilir ya da ma\u011Fazalar\u0131m\u0131za iade edebilirsiniz.")),
                React.createElement("div", { className: "tabMenuIcerik", id: "tab3icerik" },
                    React.createElement("span", { className: "tabMenuYazi" },
                        React.createElement(Icon.CheckLg, { className: "tabMenuIcon" }),
                        " Standart teslimat ile hafta i\u00E7i saat 14:00'a kadar verilen sipari\u015Fler ayn\u0131 g\u00FCn, hafta i\u00E7i 14:00'dan sonra verilen sipari\u015Fler ve hafta sonu verilen sipari\u015Fler bir sonraki i\u015F g\u00FCn\u00FC kargoya verilir."))))));
};
exports.default = TabMenu;
//# sourceMappingURL=TabMenu.js.map