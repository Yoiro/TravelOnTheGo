"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var travel_service_1 = require("../Services/travel.service");
var forms_1 = require("@angular/forms");
var global_1 = require("../Shared/global");
var TravelsComponent = (function () {
    function TravelsComponent(fb, _travelService) {
        this.fb = fb;
        this._travelService = _travelService;
        this.indLoading = false;
    }
    TravelsComponent.prototype.ngOnInit = function () {
        this.LoadTravels();
    };
    TravelsComponent.prototype.LoadTravels = function () {
        var _this = this;
        this.indLoading = true;
        this._travelService.get(global_1.Global.TRAVEL_ENDPOINT)
            .subscribe(function (travels) { _this.travels = travels; _this.indLoading = false; }, function (error) { return _this.msg = error; });
    };
    return TravelsComponent;
}());
TravelsComponent = __decorate([
    core_1.Component({
        templateUrl: 'app/Components/Templates/travels.component.html'
    }),
    __metadata("design:paramtypes", [forms_1.FormBuilder, travel_service_1.TravelService])
], TravelsComponent);
exports.TravelsComponent = TravelsComponent;
//# sourceMappingURL=travels.component.js.map