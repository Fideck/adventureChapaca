import { Component } from '@angular/core';

import { Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { MatSelect } from '@angular/material/select';
import { Dialog } from '@angular/cdk/dialog';
import { IUser } from 'src/app/core/interface/User';


@Component({
  selector: 'app-register-user',
  templateUrl: './register-user.component.html',
  styleUrls: ['./register-user.component.css']
})
export class RegisterUserComponent {
  hide = true;
  datosUsuarios: any = {};
  form: FormGroup;
  operacion: string = 'Agregar'
  id: number | undefined;
  sel: any;
  constructor(public dialogRef: MatDialogRef<RegisterUserComponent>,

    private fb: FormBuilder,
    @Inject(MAT_DIALOG_DATA) public data: any,) {
    this.form = this.propUsuario();
    this.id = data.id;
  }

  propUsuario() {
    return this.fb.group({
      nombre: ['', Validators.required],
      apellido: ['', Validators.required],
      email: ['',[ Validators.email]],
      barrio_zona:[''],
      telefono: ['', [Validators.required, Validators.pattern("^[0-9]*$")]],
      nombreUsuario: ['', Validators.required],
      contrasenia: ['', Validators.required],
      rolUsuario: ['', Validators.required]
    });
  }

  agregarUsuario() {
    // const usuario: IUser = {
    //   nombreUsuario: this.form.value.nombreUsuario,
    //   rolUsuario: this.form.value.rolUsuario,
    //   contraseniaUsuario: this.form.value.contrasenia,
    //   persona: {
    //     nombrePersona: this.form.value.nombrePersona,
    //     apellidoPersona: this.form.value.apellidoPersona,
    //     edadPersona: this.form.value.edad,
    //     ciPersona: this.form.value.ci,
    //     celularPersona: this.form.value.celular,
    //     email: this.form.value.email,
    //     barrio_zona:this.form.value.barrio_zona,
    //     estadoPersona: 1
    //   },
    //   estadoUsuario: 1
    // }
    // if (this.form.invalid) {
    //   return;
    // }

    // if (this.id == undefined) {
    //   this.UsuarioService.enviarUsuario(usuario).subscribe(() => {
    //     this._alertaService.mensajeAgregar("Usuario agregado");
    //   });
    //   this.dialogRef.close();

    // }else {
    //   console.log(usuario)
    //   this.UsuarioService.modificarUsuario(this.id, usuario).subscribe(r => {
    //     this._alertaService.mensajeAgregar("Usuario modificado");
    //   });
    //   this.dialogRef.close(true);
    // }
  }
}
