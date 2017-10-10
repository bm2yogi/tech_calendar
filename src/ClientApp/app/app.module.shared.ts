import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { MeetupsComponent } from './components/meetups/meetups.component';
import { CounterComponent } from './components/counter/counter.component';

export const sharedConfig: NgModule = {
    bootstrap: [ AppComponent ],
    declarations: [
        AppComponent,
        NavMenuComponent,
        CounterComponent,
        MeetupsComponent,
        HomeComponent
    ],
    imports: [
        RouterModule.forRoot([
            { path: '', redirectTo: 'meetups', pathMatch: 'full' },
            // { path: '', redirectTo: 'home', pathMatch: 'full' },
            // { path: 'home', component: HomeComponent },
            // { path: 'counter', component: CounterComponent },
            { path: 'meetups', component: MeetupsComponent },
            { path: '**', redirectTo: 'meetups' }
        ])
    ]
};
