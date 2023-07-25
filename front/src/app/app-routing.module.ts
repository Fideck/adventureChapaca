import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: 'home',
    loadChildren: () => import('./modules/home/inicio.module').then(m => m.InicioModule),
  },
  {
    path: 'auth',
    loadChildren: () => import('./modules/auth/acceso.module').then(m => m.AccesoModule),
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
