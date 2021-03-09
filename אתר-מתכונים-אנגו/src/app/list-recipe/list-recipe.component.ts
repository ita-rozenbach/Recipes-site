import { Component, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { Category } from 'src/modals/Category';
import { Recipe } from 'src/modals/Recipe';
import { CategoryService } from '../category.service';
import { RecipeServiceService } from '../recipe-service.service';

@Component({
  selector: 'app-list-recipe',
  templateUrl: './list-recipe.component.html',
  styleUrls: ['./list-recipe.component.css']
})
export class ListRecipeComponent implements OnDestroy {
  subscription: Subscription = null;
  subscription1: Subscription = null;

  arreyRecipes: Array<Recipe>;
  newListRecipe: Recipe[];
  allCategories: Category[];

  changeClickedRecipe(item: Recipe) {
    this.RecipeSer.clickedRecipe = item;
    this.router.navigate(['fullrecipe', item.codeRecipe]);
  }
  category: number;
  getResultSearch(name: string, category2: string, time: number) {
    console.log("hiiiiiiii");
    this.category = parseInt(category2);
    this.newListRecipe = []; this.arreyRecipes = [];

    this.arreyRecipes2.forEach(item => {
      if ((item.nameRecipe.includes(name) || name == "") && (item.codeCategory == this.category || this.category == parseInt('00')) && (item.timeAtMinute == time || time == 0)) {
        this.newListRecipe.push(item);
      }
      this.arreyRecipes = this.newListRecipe;
    })

  }

  arreyRecipes2: Recipe[];
  constructor(public RecipeSer: RecipeServiceService, public router: Router, public categorySer: CategoryService) {
    this.subscription = this.categorySer.getAllCategories().subscribe(p => { this.allCategories = p; console.log(this.allCategories); }, err => console.log("cant got categories"));
    this.subscription1 = this.RecipeSer.getsRecipes().subscribe(p => { this.arreyRecipes = p; this.arreyRecipes2 = this.arreyRecipes; }, err => console.log(err));
  }
  ngOnDestroy(): void {
    if (this.subscription)
      this.subscription.unsubscribe();
    if (this.subscription1)
      this.subscription1.unsubscribe();
  }
}
