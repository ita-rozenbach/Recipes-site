import { Component, Input, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { Recipe } from 'src/modals/Recipe';
import { CategoryService } from '../category.service';
import { RecipeServiceService } from '../recipe-service.service';
import { UserSerService } from '../user-ser.service';

@Component({
  selector: 'app-full-recipe',
  templateUrl: './full-recipe.component.html',
  styleUrls: ['./full-recipe.component.css']
})
export class FullRecipeComponent implements OnInit,OnDestroy {
subscription:Subscription=null;
subscription1:Subscription=null;
  myRecipe: Recipe;
  test: string;
  constructor(public active: ActivatedRoute, public router: Router, public recipeSer: RecipeServiceService, public categorySer: CategoryService, public userSer: UserSerService) {
    this.active.params.subscribe(param => {
      this.myRecipe = param["myRecipe"]
    })
    this.myFullRecipe = recipeSer.clickedRecipe;

    this.subscription=this.categorySer.getRecipeByCode(this.myFullRecipe.codeCategory).subscribe(p => this.nameCategoryOfMyFullRecipe = p.name, err => console.log(this.myFullRecipe.codeCategory));
   this.subscription1= this.userSer.getAllUser().subscribe(p => {
      p.forEach(t => {
        console.log(t.name);
        if (t.code == this.myFullRecipe.userCode) {
          // console.log(t.name);
          // console.log("אני בתוך האיפ")
          this.test = t.name;
        }
      })
    })


  }
  
  myFullRecipe: Recipe;
  nameCategoryOfMyFullRecipe: String;

  getCatortyImg() {
    return "./assets/" + this.myFullRecipe.codeCategory + ".png";
  }

  counter() {
    return new Array(this.myFullRecipe.LevelDifficulty);
  }

  isTheSameUserAdded() {
    console.log("userrr check")
    if (this.myFullRecipe.userCode == JSON.parse(sessionStorage.getItem('user')).code)
      return true;
     console.log("false") 
    return false;
  }

  // getNameOfuserRecipe() {
  //   this.userSer.getAllUser().subscribe(p => {
  //     p.forEach(t => {
  //       console.log(t)
  //       if (t.code == this.myFullRecipe.userCode) {
  //         console.log(t.name);
  //         this.test = t.name;
  //       }
  //     })
  //   })
  // }


  ngOnInit(): void {
  }

  changeRoutingToEdit(){
    this.router.navigate(['editrecipe', this.myFullRecipe.codeRecipe]);
  }
  ngOnDestroy(): void {
    this.subscription1.unsubscribe();
    this.subscription.unsubscribe();
  }

}
