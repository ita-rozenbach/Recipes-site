import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from '../login/login.component';
import { RegisterComponent } from '../register/register.component';


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    // RouterModule.forRoot(routes)
  ],
    exports: [RouterModule]
  
})
export class AppRoutingModule { }
