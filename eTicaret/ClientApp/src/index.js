"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
require("bootstrap/dist/css/bootstrap.css");
require("bootstrap/dist/js/bootstrap.bundle");
var React = require("react");
var ReactDOM = require("react-dom");
var react_redux_1 = require("react-redux");
var configureStore_1 = require("./store/configureStore");
var App_1 = require("./App");
var registerServiceWorker_1 = require("./registerServiceWorker");
// Get the application-wide store instance, prepopulating with state from the server where available.
var store = (0, configureStore_1.default)();
ReactDOM.render(React.createElement(react_redux_1.Provider, { store: store },
    React.createElement(App_1.default, null)), document.getElementById('root'));
(0, registerServiceWorker_1.default)();
//# sourceMappingURL=index.js.map