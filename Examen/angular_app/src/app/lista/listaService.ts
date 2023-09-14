import { Injectable } from '@angular/core'
import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { ILista } from './ILista';
import { Observable, throwError } from "rxjs";
import { catchError, tap } from 'rxjs/operators';
@Injectable({
    providedIn: 'root'
})

export class listaService {
    historialUrl: string;

    private http: HttpClient;


    constructor(httpClient: HttpClient) {
        this.historialUrl = 'http://localhost:5067/api/Persona';
        this.http = httpClient;

    }


    getHistorial(): Observable<ILista[]> {
        return this.http.get<ILista[]>(this.historialUrl).pipe(
            catchError(this.handleError)
        );
    }

    private handleError(err: HttpErrorResponse): Observable<never> {
        let errorMessage = '';
        if (err.error instanceof ErrorEvent) {
            errorMessage = `An error occurred: ${err.error.message}`;
        } else {
            errorMessage = `Server returned code: ${err.status}, error message is: ${err.message}`;
        }
        console.error(errorMessage);
        return throwError(errorMessage);
    }

}