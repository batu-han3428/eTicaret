"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var React = require("react");
require("./UrunFotograf.css");
var Icon = require("react-bootstrap-icons");
require("./UrunFotografJs.js");
var UrunFotograf = function () {
    return (React.createElement("div", { className: "col-md-6 border-end", id: "ucretsizKargoUrunFotografSutun" },
        React.createElement("div", { style: { marginTop: "10px" } },
            React.createElement("div", { id: "ucretsizKargo" },
                React.createElement("div", { id: "ucretsizKargoIconAlan" },
                    React.createElement(Icon.Truck, { id: "ucretsizKargoIcon" })),
                React.createElement("div", { id: "ucretsizKargoYaziAlan" },
                    React.createElement("span", { id: "ucretsizKargoYazi" }, "\u00DCcretsiz Kargo")))),
        React.createElement("div", { id: "KontrolTusuTetikle1", className: "carousel slide slider1" },
            React.createElement("div", { className: "carousel-inner" },
                React.createElement("div", { className: "carousel-item active" },
                    React.createElement("div", { id: "kartlarFotoAlan", "data-bs-target": "#xiomiredmi4foto", "data-bs-toggle": "modal" },
                        React.createElement("img", { id: "kartlarFoto", src: require('./UrunFotografImg/34867488.png'), alt: "xiomiNote8" })),
                    React.createElement("div", { className: "modal fade", id: "xiomiredmi4foto" },
                        React.createElement("div", { className: "modal-dialog modal-dialog-centered" },
                            React.createElement("div", { className: "modal-content" },
                                React.createElement("button", { style: { marginLeft: "auto" }, className: "btn-close", "data-bs-dismiss": "modal" }),
                                React.createElement("div", { className: "modal-body" },
                                    React.createElement("img", { className: "card-img-top kartlarFoto", src: require('./UrunFotografImg/34867488.png'), alt: "xiomiNote8Modal" }))))))),
            React.createElement("div", { className: "col-md-12", id: "tuslar" },
                React.createElement("div", null,
                    React.createElement("button", { className: "tusButonlari", "data-bs-target": "#KontrolTusuTetikle1", "data-bs-slide-to": "0" },
                        React.createElement("div", { id: "kartlarFotoAlanTus" },
                            React.createElement("img", { id: "kartlarFotoTus", src: require('./UrunFotografImg/34867488.png'), alt: "xiomiNote8Tus" }))))))));
};
exports.default = UrunFotograf;
//# sourceMappingURL=UrunFotograf.js.map