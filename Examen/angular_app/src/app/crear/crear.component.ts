import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { crearService } from './crearService';
import { ICrear } from './ICrear';
import { Validators, FormBuilder, FormGroup } from '@angular/forms';
import { ILista } from '../lista/ILista';
import { listaService } from '../lista/listaService';

@Component({
  selector: 'app-crear',
  templateUrl: './crear.component.html',
  styleUrls: ['./crear.component.css']
})
export class CrearComponent {
  nacimiento: string = "";
  nombre: string = "";
  telefono: string = "";
  resultRegistro: string = "";
  myForm!: FormGroup;
  lista: ILista[] = [];
  sub1!:Subscription;
  constructor(private crearService: crearService, public fb: FormBuilder, public listaService:listaService) {
    this.myForm = this.fb.group({
      nacimiento: ['', [Validators.required, Validators.max(new Date(new Date().getFullYear() - 14).getTime()), Validators.min(new Date(new Date().getFullYear() - 150).getTime())]],
      telefono: ['', [Validators.maxLength(25), Validators.pattern(/^\+[0-9]{1,3}-[0-9]{3,14}$/)]],
      nombre: ['', [Validators.required, Validators.maxLength(50), Validators.pattern('^[a-zA-Z ]{1,50}')]]
    });
  }
  rellenarRegistro(myForm : FormGroup): void {
    const registroDTO: ICrear = {
      nombre: myForm.value.nombre,
      telefono: myForm.value.telefono,
      fechanacimiento: myForm.value.nacimiento
    };
    this.postRegistro(registroDTO);
  }

  cargar(cambio:boolean):void{
    this.sub1 = this.listaService.getHistorial().subscribe({
      next: personas =>{
        this.lista = personas
      }
    })
  }

  postRegistro(registroDTO: ICrear): void {
  this.crearService.postCrear(registroDTO).subscribe({
    next:(registro) => {
      this.resultRegistro = registro;
      this.cargar(true);
    }
  });
}
}
