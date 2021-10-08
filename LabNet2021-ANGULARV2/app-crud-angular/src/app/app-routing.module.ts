import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ShippersFormComponent } from './modules/crud-shippers/components/shippers-form/shippers-form.component';
import { ShippersListComponent } from './modules/crud-shippers/components/shippers-list/shippers-list.component';

const routes: Routes = [
  {path: '',
  component: ShippersListComponent},
  {path: 'form',
  component: ShippersFormComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
