import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Recipe } from 'src/modals/Recipe';

@Injectable({
  providedIn: 'root'
})
export class RecipeServiceService {

clickedRecipe:Recipe;

  getsRecipes(){
    return this.http.get<Array<Recipe>>("http://localhost:4300/api/Recipe/getsRecipes");
  }

  AddRecipe(r:Recipe){
    return this.http.post<boolean>("http://localhost:4300/api/Recipe/AddRecipe",r);
  }
  
  editRecipe(r:Recipe){
    return this.http.post<boolean>("http://localhost:4300/api/Recipe/editRecipe",r);
  }
  getRecipeByCode(code:number){
    return this.http.get<Recipe>("http://localhost:4300/api/Recipe/RecipeByCode?code="+code);
  }

  getResultSearch(name:string,codeCategory:number,time:number){
    return this.http.get<Recipe>("http://localhost:4300/api/Recipe/getResultSearch?name="+name+"&category="+codeCategory+"&time="+time);
  }
  constructor(public http:HttpClient){ 
  }


}
