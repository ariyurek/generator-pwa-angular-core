import { NgModule } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import { MaterialModule } from '@angular/material';

import { routing } from './app.routes';
import { AppService } from './app.service';
import { AppComponent } from './app.component';

import { HomeComponent } from './home/home.component';
import { PersonComponent } from './person/person.component';

@NgModule({
    declarations: [AppComponent, HomeComponent, PersonComponent],
    imports: [
        BrowserAnimationsModule,
        BrowserModule,
        routing,
        MaterialModule,
        HttpModule
    ],
    providers: [
        AppService
    ],
    bootstrap: [AppComponent]
})
export class AppModule { }