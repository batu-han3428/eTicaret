"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var React = require("react");
var SiteReklam_1 = require("./SiteReklam");
var Slider_1 = require("./Slider");
var GununFirsatiFoto_1 = require("./GununFirsatiFoto");
var SliderKart_1 = require("./SliderKart");
var PcReklam_1 = require("./PcReklam");
var TanitimKart_1 = require("./TanitimKart");
var Home = function () {
    return (React.createElement("div", { className: "container-fluid", style: { backgroundColor: "rgb(243, 243, 243)", paddingBottom: "25px" } },
        React.createElement(SiteReklam_1.default, null),
        React.createElement("div", { className: "container mt-4" },
            React.createElement("div", { className: "row mt-3" },
                React.createElement(Slider_1.default, null),
                React.createElement("div", { className: "row" },
                    React.createElement("div", { className: "col-md-12 text-center mt-4" },
                        React.createElement(GununFirsatiFoto_1.default, null))))),
        React.createElement("div", { className: "container-fluid " },
            React.createElement(SliderKart_1.default, null),
            React.createElement(PcReklam_1.default, null)),
        React.createElement("div", { className: "container mt-3", style: { backgroundColor: "white", boxShadow: "0px 2px rgb(221, 221, 221)" } }),
        React.createElement("div", { className: "container", id: "tan\u0131t\u0131mKart" },
            React.createElement(TanitimKart_1.default, null))));
};
exports.default = Home;
//# sourceMappingURL=Home.js.map