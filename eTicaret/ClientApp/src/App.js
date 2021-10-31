"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var React = require("react");
var Header_1 = require("./components/layout/Header/Header");
var Footer_1 = require("./components/layout/Footer/Footer");
var react_router_dom_1 = require("react-router-dom");
var Home_1 = require("./components/Home/Home");
var About_1 = require("./components/About/About");
var Products_1 = require("./components/Products/Products");
var NotFound_1 = require("./components/NotFound/NotFound");
var ProductDetails_1 = require("./components/ProductDetails/ProductDetails");
require("./custom.css");
exports.default = (function () { return (React.createElement(react_router_dom_1.BrowserRouter, null,
    React.createElement(react_router_dom_1.Switch, null,
        React.createElement(react_router_dom_1.Route, { exact: true, path: ["/", "/home", "/Ev", "/Anasayfa", "/hakkimizda", "/about", "/telefon", "/bilgisayar", "/tvsesvegoruntusistemleri", "/beyazesyaveankastre", "/elektriklievaletleriveyasam", "/kisiselbakimvesaglik", "/oyunkonsollarihobiveeglence", "/fotografmakinesi", "/ofismalzemelerivemobilyalari", "/aksesuarlar", "/kurulumdestekpaketleri", "/telefon/:id", "/bilgisayar/:id", "/tvsesvegoruntusistemleri/:id", "/beyazesyaveankastre/:id", "/elektriklievaletleriveyasam/:id", "/kisiselbakimvesaglik/:id", "/oyunkonsollarihobiveeglence/:id", "/fotografmakinesi/:id", "/ofismalzemelerivemobilyalari/:id", "/aksesuarlar/:id", "/kurulumdestekpaketleri/:id"], render: function (props) { return (React.createElement(React.Fragment, null,
                React.createElement(Header_1.default, null),
                React.createElement(react_router_dom_1.Switch, null,
                    React.createElement(react_router_dom_1.Route, { exact: true, path: ["/", "/home", "/Ev", "/Anasayfa"], component: Home_1.default }),
                    React.createElement(react_router_dom_1.Route, { path: ["/hakkimizda", "/about"], component: About_1.default }),
                    React.createElement(react_router_dom_1.Route, { exact: true, path: ["/telefon", "/bilgisayar", "/tvsesvegoruntusistemleri", "/beyazesyaveankastre", "/elektriklievaletleriveyasam", "/kisiselbakimvesaglik", "/oyunkonsollarihobiveeglence", "/fotografmakinesi", "/ofismalzemelerivemobilyalari", "/aksesuarlar", "/kurulumdestekpaketleri"], component: Products_1.default }),
                    React.createElement(react_router_dom_1.Route, { path: ["/telefon/:id", "/bilgisayar/:id", "/tvsesvegoruntusistemleri/:id", "/beyazesyaveankastre/:id", "/elektriklievaletleriveyasam/:id", "/kisiselbakimvesaglik/:id", "/oyunkonsollarihobiveeglence/:id", "/fotografmakinesi/:id", "/ofismalzemelerivemobilyalari/:id", "/aksesuarlar/:id", "/kurulumdestekpaketleri/:id"], component: ProductDetails_1.default })),
                React.createElement(Footer_1.default, null))); } }),
        React.createElement(react_router_dom_1.Route, { component: NotFound_1.default })))); });
//# sourceMappingURL=App.js.map