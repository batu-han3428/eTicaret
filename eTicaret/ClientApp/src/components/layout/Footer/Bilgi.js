Object.defineProperty(exports, "__esModule", { value: true });
var React = require("react");
var Icon = require("react-bootstrap-icons");
require("./Bilgi.css");
var Bilgi = function () {
    return (React.createElement("div", { className: "container", id: "yardimContainer" },
        React.createElement("div", { className: "row mt-4" },
            React.createElement("div", { className: "col-md-12", id: "yardimSutun" },
                React.createElement("div", { className: "topAlanDivYardim" },
                    React.createElement("div", { className: "topYardim", onClick: function () { return window.location.href = '#'; } },
                        React.createElement(Icon.TelephoneFill, { className: "kategoriIkonYardim" })),
                    React.createElement("div", { className: "yaziYardim" },
                        React.createElement("a", { href: "#" },
                            React.createElement("span", { className: "musteri" }, "M\u00FC\u015Fteri Hizmetleri"),
                            React.createElement("span", { className: "no" }, "0850 255 34 51")))),
                React.createElement("div", { className: "topAlanDivYardim" },
                    React.createElement("div", { className: "topYardim", onClick: function () { return window.location.href = '#'; } },
                        React.createElement(Icon.GeoAltFill, { className: "kategoriIkonYardim" })),
                    React.createElement("div", { className: "yaziYardim" },
                        React.createElement("a", { href: "#" },
                            React.createElement("span", { className: "musteri" }),
                            React.createElement("span", { className: "no" }, "Ma\u011Fazalar\u0131m\u0131z")))),
                React.createElement("div", { className: "topAlanDivYardim" },
                    React.createElement("div", { className: "topYardim", onClick: function () { return window.location.href = '#'; } },
                        React.createElement(Icon.QuestionLg, { className: "kategoriIkonYardim" })),
                    React.createElement("div", { className: "yaziYardim" },
                        React.createElement("a", { href: "#" },
                            React.createElement("span", { className: "musteri" }),
                            React.createElement("span", { className: "no" }, "Yard\u0131m Merkezi")))),
                React.createElement("div", { className: "topAlanDivYardim" },
                    React.createElement("div", { className: "topYardim", onClick: function () { return window.location.href = '#'; } },
                        React.createElement(Icon.ArrowRepeat, { className: "kategoriIkonYardim" })),
                    React.createElement("div", { className: "yaziYardim" },
                        React.createElement("a", { href: "#" },
                            React.createElement("span", { className: "musteri" }),
                            React.createElement("span", { className: "no" }, "Garanti & \u0130ade")))),
                React.createElement("div", { className: "topAlanDivYardim" },
                    React.createElement("div", { className: "topYardim", onClick: function () { return window.location.href = '#'; } },
                        React.createElement(Icon.EnvelopeFill, { className: "kategoriIkonYardim" })),
                    React.createElement("div", { className: "yaziYardim" },
                        React.createElement("a", { href: "#" },
                            React.createElement("span", { className: "musteri" }),
                            React.createElement("span", { className: "no" }, "\u0130leti\u015Fim"))))))));
};
exports.default = Bilgi;
//# sourceMappingURL=Bilgi.js.map