"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var React = require("react");
var Icon = require("react-bootstrap-icons");
require("./UstAlan.css");
var react_router_dom_1 = require("react-router-dom");
var Header = function () {
    return (React.createElement("div", { className: "container" },
        React.createElement("div", { className: "row" },
            React.createElement("div", { className: "col-md-12 mt-4 text-end", id: "badges" },
                React.createElement("span", { id: "", className: "badge text-muted" },
                    React.createElement(Icon.GeoAltFill, null),
                    " Ma\u011Faza Bul"),
                React.createElement("span", { id: "", className: "badge text-muted" },
                    React.createElement(Icon.BoxSeam, null),
                    " Kargom Nerede?"),
                React.createElement("span", { id: "", className: "badge text-muted" },
                    React.createElement(Icon.InfoCircleFill, null),
                    " Yard\u0131m Merkezi"),
                React.createElement("span", { id: "", className: "badge text-muted" },
                    React.createElement(Icon.FileEarmarkMedical, null),
                    " Garanti & \u0130ade"),
                React.createElement("span", { id: "", className: "badge text-muted" },
                    React.createElement(Icon.ChatDotsFill, null),
                    " \u0130leti\u015Fim"))),
        React.createElement("div", { className: "row mt-4" },
            React.createElement("div", { className: "col-md-2 me-5 align-self-center", id: "foto" },
                React.createElement(react_router_dom_1.Link, { to: "/" },
                    React.createElement("img", { id: "2", src: require('../../../img/logo.png'), className: "img-fluid", alt: "logo" }))),
            React.createElement("div", { className: "col-md-4  d-flex align-items-center", id: "ara" },
                React.createElement("form", { className: "col-md-12" },
                    React.createElement("div", { className: "input-group " },
                        React.createElement("input", { type: "search", id: "form", placeholder: "Ne Aramak \u0130stersiniz", className: "form-control" }),
                        React.createElement("a", { href: "#" },
                            React.createElement("button", { id: "buton", className: "btn" },
                                React.createElement(Icon.Search, null)))))),
            React.createElement("div", { className: "col-md-2 text-center", id: "siparis" },
                React.createElement("h5", { className: "text-muted siparisHatti" },
                    React.createElement(Icon.Telephone, null),
                    " ",
                    React.createElement("span", { className: "siparisHattiYazi" }, "Sipari\u015F Hatt\u0131"),
                    React.createElement("span", { className: "badge bg-warning ms-3 siparisHattiTel" }, "0850 345 6474"))),
            React.createElement("div", { className: "col-md-3 text-center", id: "sepet" },
                React.createElement("button", { className: "btn btn-outline-warning btn-lg", style: { padding: "12px 18px", position: "relative" }, disabled: true },
                    React.createElement("span", { className: "badge rounded-pill bg-warning border border-light", style: { fontSize: "10px", position: "absolute", top: "10px", left: "33px", zIndex: 1 } }, "0"),
                    React.createElement(Icon.CartFill, { style: { fontSize: "30px", zIndex: 2, marginRight: "5px" } }),
                    React.createElement("sub", null, "Sepetim"))))));
};
exports.default = Header;
//# sourceMappingURL=UstAlan.js.map