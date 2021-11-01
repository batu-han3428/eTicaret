"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var React = require("react");
var NotFound = function () {
    React.useEffect(function () {
        require('./NotFound.css');
    }, []);
    return (React.createElement(React.Fragment, null,
        React.createElement("svg", { id: "robot", version: "1.1", xmlns: "http://www.w3.org/2000/svg", xlinkHref: "http://www.w3.org/1999/xlink", x: "0", y: "0", width: "320px", height: "300px", viewBox: "0 0 160 300", "enable-background": "new 0 0 320 300" },
            React.createElement("rect", { x: "59.722", y: "72.779", fill: "#333", width: "40.557", height: "27.564" }),
            React.createElement("g", { id: "head", className: "up" },
                React.createElement("g", { id: "leftAntenna" },
                    React.createElement("path", { fill: "none", stroke: "#ccc", "stroke-width": "1.5", "stroke-miterlimit": "10", d: "M77.519,25.869\r\n\t\tC75.85,13.604,65.745,3.39,53.972,3.39" },
                        React.createElement("animate", { attributeName: "d", calcMode: "spline", keySplines: "0.42 0 0.58 1; 0.42 0 0.58 1; 0.42 0 0.58 1", begin: "0s", dur: "0.75s", repeatCount: "indefinite", values: "\r\n                          M77.519,25.869C75.85,13.604,65.745,3.39,53.972,3.39\r\n                          ;\r\n                          M77.519,25.869C75.85,13.604,65.745,3.39,53.972,12\r\n                          ;\r\n                          M77.519,25.869C75.85,13.604,65.745,3.39,53.972,0\r\n                          ;\r\n                          M77.519,25.869C75.85,13.604,65.745,3.39,53.972,3.39\r\n                          " })),
                    React.createElement("ellipse", { fill: "#ccc", cx: "55.021", cy: "3.39", rx: "3.344", ry: "3.391" },
                        React.createElement("animate", { dur: "0.75s", attributeName: "cy", calcMode: "spline", keySplines: "0.42 0 0.58 1; 0.42 0 0.58 1; 0.42 0 0.58 1", begin: "0s", values: "\r\n                           3.39;\r\n                           12;\r\n                           0;\r\n                           3.39\r\n                           ", repeatCount: "indefinite" }))),
                React.createElement("g", { id: "rightAntenna" },
                    React.createElement("path", { fill: "none", stroke: "#ccc", "stroke-width": "1.5", "stroke-miterlimit": "10", d: "M82.48,25.869\r\n\t\tC84.15,13.604,94.255,3.39,106.028,3.39" },
                        React.createElement("animate", { attributeName: "d", calcMode: "spline", keySplines: "0.42 0 0.58 1; 0.42 0 0.58 1; 0.42 0 0.58 1", begin: "0s", dur: "0.6s", repeatCount: "indefinite", values: "\r\n                          M82.48,25.869C84.15,13.604,94.255,3.39,106.028,3.39\r\n                          ;\r\n                          M82.48,25.869C84.15,13.604,94.255,3.39,106.028,10.39\r\n                          ;\r\n                          M82.48,25.869C84.15,13.604,94.255,3.39,106.028,-5.39\r\n                          ;\r\n                          M82.48,25.869C84.15,13.604,94.255,3.39,106.028,3.39\r\n                          " })),
                    React.createElement("ellipse", { fill: "#ccc", cx: "104.979", cy: "3.39", rx: "3.344", ry: "3.391" },
                        React.createElement("animate", { dur: "0.6s", attributeName: "cy", calcMode: "spline", keySplines: "0.42 0 0.58 1; 0.42 0 0.58 1; 0.42 0 0.58 1", begin: "0s", values: "\r\n                           3.39;\r\n                           10.39;\r\n                           -5.39;\r\n                           3.39\r\n                           ", repeatCount: "indefinite" }))),
                React.createElement("path", { fill: "#333", d: "M96.079,32.57v-8.546c-10.72-3.765-21.437-3.98-32.156,0v8.546H96.079z" }),
                React.createElement("path", { fill: "#f54f59", d: "M112.809,28.372H80H47.19c-5.814,18.663-5.499,37.322,0,55.983H80h32.811\r\n\t\tC118.309,65.694,118.625,47.035,112.809,28.372z" }),
                React.createElement("g", null,
                    React.createElement("g", { id: "eyeLeft" },
                        React.createElement("path", { fill: "#FFFFFF", d: "M72.116,47.955c0,5.443-4.045,9.853-9.033,9.853h-1.971c-4.988,0-9.032-4.41-9.032-9.853\r\n\t\t\t\ts4.044-9.856,9.032-9.856h1.971C68.071,38.099,72.116,42.512,72.116,47.955z" },
                            React.createElement("animate", { attributeName: "d", calcMode: "spline", keySplines: "0.42 0 0.58 1; 0.42 0 0.58 1", begin: "5s", dur: "0.8s", repeatCount: "indefinite", values: "\r\n                          M72.116,47.955c0,5.443-4.045,9.853-9.033,9.853h-1.971c-4.988,0-9.032-4.41-9.032-9.853s4.044-9.856,9.032-9.856h1.971C68.071,38.099,72.116,42.512,72.116,47.955z\r\n                          ;\r\n                          M72.116,47.955c0,5.443-0.045,9.853-9.033,9.853h-1.971c-4.988,0-9.032-4.41-9.032-9.853s4.044-4.856,9.032-4.856h1.971C68.071,45.099,72.116,42.512,72.116,47.955z\r\n                          ;\r\n                          M72.116,47.955c0,5.443-4.045,9.853-9.033,9.853h-1.971c-4.988,0-9.032-4.41-9.032-9.853s4.044-9.856,9.032-9.856h1.971C68.071,38.099,72.116,42.512,72.116,47.955z\r\n                          " })),
                        React.createElement("path", { d: "M66.614,47.955c0,2.176-1.618,3.942-3.613,3.942h-1.807c-1.994,0-3.612-1.766-3.612-3.942\r\n\t\t\t\tc0-2.178,1.618-3.943,3.612-3.943H63C64.996,44.012,66.614,45.777,66.614,47.955z" })),
                    React.createElement("g", null,
                        React.createElement("path", { fill: "#FFFFFF", d: "M107.92,47.955c0,5.443-4.045,9.853-9.031,9.853h-1.973c-4.986,0-9.031-4.41-9.031-9.853\r\n\t\t\t\ts4.045-9.856,9.031-9.856h1.973C103.875,38.099,107.92,42.512,107.92,47.955z" },
                            React.createElement("animate", { attributeName: "d", calcMode: "spline", keySplines: "0.42 0 0.58 1; 0.42 0 0.58 1", begin: "5s", dur: "0.8s", repeatCount: "indefinite", values: "\r\n                          M107.92,47.955c0,5.443-4.045,9.853-9.031,9.853h-1.973c-4.986,0-9.031-4.41-9.031-9.853s4.045-9.856,9.031-9.856h1.973C103.875,38.099,107.92,42.512,107.92,47.955z\r\n                          ;\r\n                          M107.92,47.955c0,5.443-4.045,9.853-9.031,9.853h-1.973c-4.986,0-9.031-4.41-9.031-9.853s4.045-4.856,9.031-4.856h1.973C103.875,45.099,107.92,42.512,107.92,47.955z\r\n                          ;\r\n                          M107.92,47.955c0,5.443-4.045,9.853-9.031,9.853h-1.973c-4.986,0-9.031-4.41-9.031-9.853s4.045-9.856,9.031-9.856h1.973C103.875,38.099,107.92,42.512,107.92,47.955z\r\n                          " })),
                        React.createElement("path", { d: "M102.417,47.955c0,2.176-1.616,3.942-3.612,3.942h-1.807c-1.994,0-3.611-1.766-3.611-3.942\r\n\t\t\t\tc0-2.178,1.617-3.943,3.611-3.943h1.807C100.801,44.012,102.417,45.777,102.417,47.955z" }))),
                React.createElement("path", { fill: "#FFFFFF", d: "M103.383,69.778c0,1.381-0.836,2.499-1.871,2.499c-10.756,0-32.269,0-43.025,0\r\n\t\tc-1.033,0-1.871-1.118-1.871-2.499c0-1.378,0.838-2.496,1.871-2.496c10.756,0,32.269,0,43.025,0\r\n\t\tC102.547,67.282,103.383,68.4,103.383,69.778z" },
                    React.createElement("animate", { attributeName: "d", calcMode: "spline", keySplines: "0.42 0 0.58 1; 0.42 0 0.58 1; 0.42 0 0.58 1", begin: "0s", dur: "1s", repeatCount: "indefinite", values: "\r\n                          M103.383,69.778c0,1.381-0.836,2.499-1.871,2.499c-10.756,0-32.269,0-43.025,0\r\n\t\tc-1.033,0-1.871-1.118-1.871-2.499c0-1.378,0.838-2.496,1.871-2.496c10.756,0,32.269,0,43.025,0\r\n\t\tC102.547,67.282,103.383,68.4,103.383,69.778z\r\n                          ;\r\n                          M103.383,69.778c0,1.381-0.862,2.268-1.871,2.499c-11.669,2.677-29.396,3.207-43.025,0\r\n\t\tc-1.005-0.236-1.871-1.118-1.871-2.499c0-1.378,0.868-2.249,1.871-2.496c11.349-2.795,31.753-2.53,43.025,0\r\n\t\tC102.521,67.508,103.383,68.4,103.383,69.778z\r\n                          ;\r\n                          M103.383,69.778c0,1.381-0.86,2.724-1.871,2.499c-11.271-2.506-29.956-2.201-43.025,0\r\n\t\tc-1.019,0.171-1.871-1.118-1.871-2.499c0-1.378,0.89-2.819,1.871-2.496c15.191,4.995,30.429,3.433,43.025,0\r\n\t\tC102.511,67.01,103.383,68.4,103.383,69.778z\r\n                          ;\r\n                          M103.383,69.778c0,1.381-0.836,2.499-1.871,2.499c-10.756,0-32.269,0-43.025,0\r\n\t\tc-1.033,0-1.871-1.118-1.871-2.499c0-1.378,0.838-2.496,1.871-2.496c10.756,0,32.269,0,43.025,0\r\n\t\tC102.547,67.282,103.383,68.4,103.383,69.778z\r\n                          " }))),
            React.createElement("g", { id: "upperTorso" },
                React.createElement("g", { id: "leftArm" },
                    React.createElement("g", { className: "forearm" },
                        React.createElement("path", { fill: "#333", d: "M9.068,131.177c-4.78,12.558-5.183,25.372-2.497,40.71c0,0,0.68,4.312,6.107,3.39\r\n\t\tc4.571-0.776,4.348-5.001,4.348-5.001c-2.351-13.388-2.234-24.244,1.89-35.134c0,0,1.75-4.725-2.833-6.6\r\n\t\tC11.02,126.471,9.068,131.177,9.068,131.177z" }),
                        React.createElement("path", { fill: "#f54f59", d: "M9.604,166.5c-6.984,1.975-11.067,9.316-9.117,16.398c1.008,3.662,3.439,6.522,6.51,8.172\r\n\t\tc-0.167-0.363-0.315-0.742-0.426-1.141c-1.235-4.484,1.703-9.234,6.562-10.609c4.861-1.377,9.804,1.145,11.037,5.631\r\n\t\tc0.111,0.396,0.18,0.798,0.221,1.197c1.785-3.021,2.399-6.748,1.393-10.407C23.833,168.661,16.589,164.523,9.604,166.5z" })),
                    React.createElement("path", { fill: "#333", d: "M18.917,135.142c1.731-4.573,4.169-9.151,7.428-13.925c4.23-6.199,7.573-9.281,13.553-13.761\r\n\t\tc0,0,3.335-2.905,0.961-6.63c-2.797-4.389-7.415-1.908-7.415-1.908c-4.981,3.145-10.421,8.413-15.576,15.872\r\n\t\tc-3.827,5.537-6.726,10.938-8.8,16.387c0,0-1.877,4.187,2.599,6.24C16.75,139.75,18.917,135.142,18.917,135.142z" }),
                    React.createElement("g", null,
                        React.createElement("ellipse", { stroke: "#f54f59", cx: "13.581", cy: "132.93", rx: "8.505", ry: "8.623" }),
                        React.createElement("g", null,
                            React.createElement("path", { fill: "#f54f59", d: "M9.299,135.199c1.237,2.396,4.154,3.322,6.52,2.07c2.364-1.252,3.278-4.211,2.042-6.605\r\n\t\t\t\tc-1.236-2.398-4.152-3.324-6.52-2.072C8.978,129.844,8.065,132.803,9.299,135.199z" })))),
                React.createElement("g", { id: "rightArm" },
                    React.createElement("g", { className: "forearm" },
                        React.createElement("path", { fill: "#333", d: "M143.916,128.542c-4.583,1.875-2.833,6.6-2.833,6.6c4.124,10.89,4.241,21.746,1.89,35.134\r\n\t\tc0,0-0.223,4.225,4.348,5.001c5.428,0.922,6.107-3.39,6.107-3.39c2.688-15.338,2.283-28.152-2.496-40.71\r\n\t\tC150.932,131.177,148.98,126.471,143.916,128.542z" }),
                        React.createElement("path", { fill: "#f54f59", d: "M134.216,175.741c-1.006,3.659-0.392,7.386,1.394,10.407c0.041-0.399,0.109-0.801,0.221-1.197\r\n\t\tc1.232-4.486,6.176-7.008,11.037-5.631c4.859,1.375,7.797,6.125,6.562,10.609c-0.111,0.398-0.26,0.777-0.427,1.141\r\n\t\tc3.071-1.649,5.502-4.51,6.511-8.172c1.949-7.082-2.134-14.424-9.117-16.398C143.411,164.523,136.167,168.661,134.216,175.741z" })),
                    React.createElement("path", { fill: "#333", d: "M148.333,137.417c4.476-2.054,2.599-6.24,2.599-6.24c-2.074-5.449-4.973-10.85-8.8-16.387\r\n\t\tc-5.155-7.459-10.595-12.727-15.576-15.872c0,0-4.618-2.48-7.415,1.908c-2.374,3.725,0.961,6.63,0.961,6.63\r\n\t\tc5.98,4.479,9.323,7.562,13.553,13.761c3.26,4.773,5.697,9.352,7.429,13.925C141.083,135.142,143.25,139.75,148.333,137.417z" }),
                    React.createElement("g", null,
                        React.createElement("ellipse", { stroke: "#f54f59", cx: "146.419", cy: "132.93", rx: "8.505", ry: "8.623" }),
                        React.createElement("g", null,
                            React.createElement("path", { fill: "#f54f59", d: "M148.659,128.592c-2.368-1.252-5.284-0.326-6.521,2.072c-1.236,2.395-0.322,5.354,2.043,6.605\r\n\t\t\t\ts5.282,0.326,6.52-2.07C151.936,132.803,151.021,129.844,148.659,128.592z" })))),
                React.createElement("path", { d: "M42.356,94.049l-8.341-1.248c-5.238,10.201-7.014,20.918-4.697,32.248l8.34,1.248L42.356,94.049z" }),
                React.createElement("path", { d: "M122.342,126.297l8.34-1.248c2.317-11.33,0.541-22.047-4.697-32.248l-8.34,1.248L122.342,126.297z" }),
                React.createElement("path", { fill: "#f54f59", d: "M125.283,131.334c0.048-13.081-1.633-26.163-5.186-39.244H80H39.903\r\n\t\tc-3.552,13.081-5.232,26.162-5.184,39.242L125.283,131.334z" })),
            React.createElement("g", { id: "lowerTrunk" },
                React.createElement("g", { id: "leftFoot" },
                    React.createElement("path", { fill: "#333", d: "M61.27,164.817c0-3.526-2.858-6.386-6.385-6.386c-3.527,0-6.386,2.859-6.386,6.386v0.001l0,0l0,36.132\r\n\t\t\tc0,3.526,2.859,6.386,6.386,6.386c3.526,0,6.385-2.859,6.385-6.386L61.27,164.817L61.27,164.817L61.27,164.817z" }),
                    React.createElement("g", { className: "lowerLeg" },
                        React.createElement("path", { fill: "#333", d: "M61.27,200.63c0-3.526-2.858-6.386-6.385-6.386c-3.527,0-6.386,2.859-6.386,6.386v0.001l0,0l0,36.132\r\n\t\t\tc0,3.526,2.859,6.386,6.386,6.386c3.526,0,6.385-2.859,6.385-6.386L61.27,200.63L61.27,200.63L61.27,200.63z" }),
                        React.createElement("path", { fill: "#f54f59", d: "M54.885,234.096c-9.526,0-17.244,7.119-17.244,15.903H72.13C72.13,241.215,64.41,234.096,54.885,234.096z" })),
                    React.createElement("g", null,
                        React.createElement("ellipse", { stroke: "#f54f59", cx: "54.885", cy: "200.79", rx: "9.294", ry: "9.423" }),
                        React.createElement("g", null,
                            React.createElement("path", { fill: "#f54f59", d: "M60.607,203.823c-1.653,3.202-5.553,4.44-8.715,2.768c-3.163-1.677-4.383-5.628-2.73-8.832\r\n\t\t\t\t\tc1.651-3.204,5.556-4.442,8.715-2.771C61.036,196.664,62.258,200.62,60.607,203.823z" })))),
                React.createElement("g", { id: "rightFoot" },
                    React.createElement("path", { fill: "#333", d: "M98.73,164.817c0-3.526,2.858-6.386,6.385-6.386c3.527,0,6.386,2.859,6.386,6.386v0.001l0,0l0.001,36.132\r\n\t\t\tc0,3.526-2.859,6.386-6.387,6.386c-3.525,0-6.385-2.859-6.385-6.386V164.817L98.73,164.817L98.73,164.817z" }),
                    React.createElement("g", { className: "lowerLeg" },
                        React.createElement("path", { fill: "#333", d: "M98.73,200.63c0-3.526,2.858-6.386,6.385-6.386c3.527,0,6.386,2.859,6.386,6.386v0.001l0,0l0.001,36.132\r\n\t\t\tc0,3.526-2.859,6.386-6.387,6.386c-3.525,0-6.385-2.859-6.385-6.386V200.63L98.73,200.63L98.73,200.63z" }),
                        React.createElement("path", { fill: "#f54f59", d: "M87.87,249.999h34.489c0-8.784-7.719-15.903-17.244-15.903S87.87,241.215,87.87,249.999z" })),
                    React.createElement("g", null,
                        React.createElement("ellipse", { stroke: "#f54f59", cx: "105.115", cy: "200.79", rx: "9.294", ry: "9.423" }),
                        React.createElement("g", null,
                            React.createElement("path", { fill: "#f54f59", d: "M102.123,194.988c3.159-1.672,7.064-0.434,8.715,2.771c1.653,3.204,0.434,7.155-2.73,8.832\r\n\t\t\t\t\tc-3.162,1.673-7.062,0.435-8.715-2.768C97.742,200.62,98.964,196.664,102.123,194.988z" })))),
                React.createElement("path", { fill: "#f7727a", d: "M34.719,131.334c0.048,13.082,1.824,26.164,5.184,39.246H80h40.098c3.361-13.08,5.138-26.162,5.186-39.244L34.719,131.334z" }))),
        React.createElement("div", { className: "col" },
            React.createElement("h1", null, "404"),
            React.createElement("p", null, "Arad\u0131\u011F\u0131n\u0131z sayfa bulunamad\u0131..."))));
};
exports.default = NotFound;
//# sourceMappingURL=NotFound.js.map