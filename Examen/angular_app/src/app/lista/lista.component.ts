import { Component, EventEmitter, Input, OnChanges, OnDestroy, OnInit, Output, SimpleChanges  } from '@angular/core';
import { Subscription } from 'rxjs';
import { ILista } from "./ILista";
import { listaService } from './listaService';

@Component({
  selector: 'app-lista',
  templateUrl: './lista.component.html',
  styleUrls: ['./lista.component.css']
})
export class ListaComponent implements OnInit, OnDestroy, OnChanges{
  errorMessage: string = '';
  sub!: Subscription;

  constructor(private listaService: listaService) {}
  idUsuario = localStorage.getItem('idUsuario')
  pageTitle : string = 'Historial';
  @Input() lista: ILista[]=[];
  @Output() cambio: EventEmitter<boolean> =
  new EventEmitter<boolean>();

  onClick(): void {
    this.cambio.emit(false);
  }
  ngOnChanges(): void {
    this.actualizar()
  }
  //Cargar el historial
  ngOnInit(): void {
      this.actualizar()
    }
  actualizar() {  
    this.sub = this.listaService.getHistorial().subscribe({
      next: lista => {
        this.lista = lista;
      },
    });
   }
    ngOnDestroy(): void {
      this.sub.unsubscribe();
    }
}
