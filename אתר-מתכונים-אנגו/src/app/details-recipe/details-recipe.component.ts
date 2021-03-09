import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Recipe } from 'src/modals/Recipe';
import { RecipeServiceService } from '../recipe-service.service';

@Component({
  selector: 'app-details-recipe',
  templateUrl: './details-recipe.component.html',
  styleUrls: ['./details-recipe.component.css'],

//   template: `
//   <app-full-recipe [fullMyRecipe]="" (parrentRecipe)="fromChild($event)"></app-full-recipe>
// `

})
export class DetailsRecipeComponent implements OnInit {
@Input()
myRecipe:Recipe;
  
constructor(public router:Router, public recipeSer:RecipeServiceService) { }
  counter() {
    return new Array(this.myRecipe.LevelDifficulty);
  }


  ngOnInit(): void {
  }

}
