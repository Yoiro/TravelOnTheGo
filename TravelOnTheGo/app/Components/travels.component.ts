import { Component, OnInit, ViewChild } from '@angular/core';
import { TravelService } from '../Services/travel.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ITravel } from '../Models/travel';
import { DBOperation } from '../Shared/enum';
import { Observable } from 'rxjs/Rx';
import { Global } from '../Shared/global';

@Component({
    
templateUrl: 'app/Components/Templates/travels.component.html'

})
export class TravelsComponent implements OnInit {
    travels: ITravel[];
    travel: ITravel;
    msg: string;
    indLoading: boolean = false;
    travelFrm: FormGroup;
    dbops: DBOperation;

    constructor(private fb: FormBuilder, private _travelService: TravelService){}

    ngOnInit(): void {        
       this.LoadTravels();
    }

    LoadTravels(): void {
           this.indLoading = true;
           this._travelService.get(Global.TRAVEL_ENDPOINT)
               .subscribe(travels => { this.travels = travels; this.indLoading = false; },
            error => this.msg = <any>error);
    }
}