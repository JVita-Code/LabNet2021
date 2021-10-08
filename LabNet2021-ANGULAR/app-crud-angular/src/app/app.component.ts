import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'CRUD Shippers';

  mostrar = true;
  frase: any = {
    mensaje: 'El Doc esta vivo!',

    autor: 'marty'
  }

  personajes: string[] = ['Marty', 'Doc', 'Biff'];
}
