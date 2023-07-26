import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environments';

@Injectable({
  providedIn: 'root'
})
export class PersonService {

constructor(private httpclient: HttpClient) {}
  obtenerPersona():Observable<any>{
    return this.httpclient.get<any>(`${environment.API_URL}/api/Person`);
  }
}
