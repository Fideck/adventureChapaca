import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AccesoRoutingModule } from './acceso-routing.module';
import { SharedModule } from 'src/app/shared/shared.module';
import { LoginComponent } from './login/login.component';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RegisterUserComponent } from './register-user/register-user.component';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatDialog, MatDialogActions, MatDialogContainer, MatDialogContent, MatDialogModule } from '@angular/material/dialog';
import { MatIconAnchor, MatIconButton } from '@angular/material/button';
import { MatOption, MatOptionModule } from '@angular/material/core';
import {MatIconModule} from '@angular/material/icon';

@NgModule({
  declarations: [
    LoginComponent,
    RegisterUserComponent
  ],
  imports: [
    CommonModule,
    AccesoRoutingModule,
    SharedModule,
    ReactiveFormsModule,
    HttpClientModule,

    MatFormFieldModule,
    MatDialogModule,
    MatOptionModule,
    MatIconModule,
  ],
  exports: [LoginComponent]
})
export class AccesoModule { }
