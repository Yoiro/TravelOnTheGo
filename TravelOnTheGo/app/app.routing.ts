import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './Components/home.component';
import { TravelsComponent } from './Components/travels.component';
import { TravelAddComponent } from './Components/travel.add.component';

const appRoutes: Routes = [    
{ path: '', redirectTo: 'home', pathMatch: 'full' },
{ path: 'home', component: HomeComponent },
{ path: 'travels', component: TravelsComponent },
{ path: 'travels/add', component: TravelAddComponent}
];

export const routing: ModuleWithProviders = RouterModule.forRoot(appRoutes);