import { ICrear } from './ICrear';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class crearService {
    conversorUrl: string;

    private http: HttpClient;

    constructor(httpClient: HttpClient) {
        this.conversorUrl = 'http://localhost:5067/api/Persona/AltaPersona';
        this.http = httpClient;
    }

    postCrear(crear: ICrear): Observable<any> {
        console.log(crear);
        return this.http.post(this.conversorUrl, crear);
    }
}