import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { InicioComponent } from './inicio/inicio.component';
import { ToursComponent } from './tours/tours.component';

const routes: Routes = [
  {
    path: '',
    children: [
      { path: 'inicio', component: InicioComponent},
      { path: 'tours', component: ToursComponent},
      { path: '**', redirectTo: 'inicio', pathMatch: 'full'},
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class InicioRoutingModule { }
