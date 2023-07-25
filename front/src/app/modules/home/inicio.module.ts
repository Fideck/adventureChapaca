import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { InicioRoutingModule } from './inicio-routing.module';
import { InicioComponent } from './inicio/inicio.component';
import { SharedModule } from 'src/app/shared/shared.module';
import { ToursComponent } from './tours/tours.component';


@NgModule({
  declarations: [
    InicioComponent,
    ToursComponent
  ],
  imports: [
    CommonModule,
    InicioRoutingModule,
    SharedModule,
  ],
  exports: [InicioComponent]
})
export class InicioModule { }
