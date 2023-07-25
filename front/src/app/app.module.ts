import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { InicioModule } from './modules/home/inicio.module';
import { AccesoModule } from './modules/auth/acceso.module';


@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    InicioModule,
    AccesoModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
