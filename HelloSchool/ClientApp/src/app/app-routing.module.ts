import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import {StepperModComponent} from './stepper-mod/stepper-mod.component'

const routes: Routes = [
  {
    path:'Preregistro',
    component:StepperModComponent
  }
]
@NgModule({
  declarations: [],
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
