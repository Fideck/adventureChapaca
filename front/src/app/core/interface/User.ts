import { IPerson } from "./Person"
export interface IUser {
  id:number,
  usuario:string,
  contrasenia:string,
  correo:string,
  tipousuario:number,
  estado:number,
  PersonId: IPerson
}
