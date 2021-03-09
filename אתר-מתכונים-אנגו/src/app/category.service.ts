import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Category } from 'src/modals/Category';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  getRecipeByCode(code:number){
    return this.http.get<Category>("http://localhost:4300/api/Category/getRecipeByCode?code="+code);
  }

  getAllCategories(){
    return this.http.get<Array<Category>>("http://localhost:4300/api/Category/getAllCategories");
  }
  sendMail(sub:string, body:string){
    return this.http.get<Array<Category>>("http://localhost:4300/api/Category/myTry?sub="+sub+"&body="+body);
  }

  constructor(public http:HttpClient) { }
}
