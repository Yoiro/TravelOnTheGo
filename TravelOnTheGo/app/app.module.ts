import { NgModule } from '@angular/core';
import { APP_BASE_HREF } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { AppComponent } from './app.component';
import { routing } from './app.routing';
import { HomeComponent } from './Components/home.component';
import { UserService } from './Services/user.service';
import { TravelService } from './Services/travel.service';
import { ReservationService } from './Services/reservation.service';
import { TravelsComponent } from './Components/travels.component';
import { TravelAddComponent } from './Components/travel.add.component';
 
@NgModule({
    imports: [BrowserModule, ReactiveFormsModule, HttpModule, routing],
    declarations: [
        AppComponent, HomeComponent, 
        TravelsComponent, TravelAddComponent
    ],
    providers: [
        { provide: APP_BASE_HREF, useValue: '/' },
        UserService,
        TravelService,
        ReservationService
    ],
    bootstrap: [AppComponent]
})
export class AppModule { }