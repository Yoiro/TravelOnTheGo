"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var router_1 = require("@angular/router");
var home_component_1 = require("./Components/home.component");
var travels_component_1 = require("./Components/travels.component");
var travel_add_component_1 = require("./Components/travel.add.component");
var appRoutes = [
    { path: '', redirectTo: 'home', pathMatch: 'full' },
    { path: 'home', component: home_component_1.HomeComponent },
    { path: 'travels', component: travels_component_1.TravelsComponent },
    { path: 'travels/add', component: travel_add_component_1.TravelAddComponent }
];
exports.routing = router_1.RouterModule.forRoot(appRoutes);
//# sourceMappingURL=app.routing.js.map