import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { HttpClient } from '@angular/common/http';
import {HttpClientModule} from '@angular/common/http';
import { RegisterComponent } from './register/register.component'
import { AppRoutingModule } from './app-routing/app-routing.module';
import { Route } from '@angular/compiler/src/core';
import { Routes, RouterModule } from '@angular/router';
import { FormsModule, NgModel, ReactiveFormsModule } from '@angular/forms';
import {NgForm} from '@angular/forms';
import { CommonModule } from '@angular/common';
import { DetailsRecipeComponent } from './details-recipe/details-recipe.component';
import { ListRecipeComponent } from './list-recipe/list-recipe.component';
import { FullRecipeComponent } from './full-recipe/full-recipe.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AddRecipeComponent } from './add-recipe/add-recipe.component';
import { TimePipePipe } from './time-pipe.pipe';
import { EditRecipeComponent } from './edit-recipe/edit-recipe.component';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { AboutComponent } from './about/about.component';
import { ContactComponent } from './contact/contact.component';


const routes: Routes = [
{path:"",component:LoginComponent,
},
{path:"login",component:LoginComponent 
},
{path:"about",component:AboutComponent 
},
{path:"register/:name",component:RegisterComponent 
},
{path:"fullrecipe/:code",component:FullRecipeComponent
},
{path:"listrecipe",component:ListRecipeComponent 
},
{path:"contact",component:ContactComponent 
},
{path:"addrecipe",component:AddRecipeComponent 
},
{path:"editrecipe/:code",component:EditRecipeComponent 
}
];

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegisterComponent,
    DetailsRecipeComponent,
    ListRecipeComponent,
    FullRecipeComponent,
    AddRecipeComponent,
    TimePipePipe,
    EditRecipeComponent,
    HeaderComponent,
    FooterComponent,
    AboutComponent,
    ContactComponent
  ],
  imports: [
    BrowserModule,RouterModule.forRoot(routes),HttpClientModule,FormsModule,CommonModule,ReactiveFormsModule, BrowserAnimationsModule


  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
