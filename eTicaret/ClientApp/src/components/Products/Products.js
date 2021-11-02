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
var react_redux_1 = require("react-redux");
var configureStore_1 = require("../../store/configureStore");
var axios_1 = require("axios");
var Products = function (props) {
    console.log(props.location.pathname);
    React.useEffect(function () {
        var store = (0, configureStore_1.default)();
        axios_1.default.post("https://localhost:5001/api/urunler/Index", props.location.pathname).then(function (res) {
            store.dispatch({
                type: "GET_USER",
                payload: res.data
            });
        });
    }, []);
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
var mapStateToProps = function (state) {
    return {
        urunler: state.urunler
    };
};
exports.default = (0, react_redux_1.connect)(mapStateToProps)(Products);
//# sourceMappingURL=Products.js.map