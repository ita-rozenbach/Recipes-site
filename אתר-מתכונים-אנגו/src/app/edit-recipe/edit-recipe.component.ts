import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router, RouterOutlet } from '@angular/router';
import { Category } from 'src/modals/Category';
import { Recipe } from 'src/modals/Recipe';
import { CategoryService } from '../category.service';
import { RecipeServiceService } from '../recipe-service.service';
import swal from 'sweetalert';

@Component({
  selector: 'app-edit-recipe',
  templateUrl: './edit-recipe.component.html',
  styleUrls: ['./edit-recipe.component.css']
})
export class EditRecipeComponent implements OnInit {
  allCategories: Category[] = [];

  code: number;
  constructor(public categorySer: CategoryService, public RecipeSer: RecipeServiceService, public active: ActivatedRoute, public router: Router) {

    active.params.subscribe(param => {
      console.log(param);
      this.code = parseInt(param["code"]);
    }, err => { })
    console.log(this.code);
    this.categorySer.getAllCategories().subscribe(p => { this.allCategories = p; console.log(this.allCategories); }, err => console.log("cant got categories"));
    this.RecipeSer.getRecipeByCode(this.code).subscribe(p => { this.myEditRecipe = p; this.arringredients = this.myEditRecipe.ingredients.split('-'); this.arrPreparation = this.myEditRecipe.Preparation.split('-'); }, err => console.log(err + "             sharattttt"));
  }

  arringredients: string[] = [];
  arrPreparation: string[] = [];
  myEditRecipe: Recipe;
  str: string = "";
  getIngredients() {
    this.str = "";
    // this.arringredients.splice(this.arringredients.length - 1);
    this.arringredients.forEach(p => {
      if(p.length>0)
      this.str += p + "-";
    });
    return this.str.substring(0, this.str.length - 1);
  }

  getPreparation() {
    this.str = "";
    // this.arrPreparation.splice(this.arrPreparation.length - 1);
    this.arrPreparation.forEach(p => {
      if(p.length>0)
      this.str += p + "-";
    });
    return this.str.substring(0, this.str.length - 1);
  }

  saveEditRecipe(codeCategory:number) {
    this.alert2();
    this.myEditRecipe.codeCategory=codeCategory;
    this.myEditRecipe.ingredients = this.getIngredients();
    this.myEditRecipe.Preparation = this.getPreparation();
    this.RecipeSer.editRecipe(this.myEditRecipe).subscribe(p => this.goToRecipe(this.myEditRecipe), err => console.log("error in edit"))
  
  }

  getCategoryByCode() {
    this.allCategories.forEach(p => {
      console.log(p);
      if (p.code == this.myEditRecipe.codeCategory)
        return p.name;
    })
  }

  trackByFn(index, item) {
    return index;
  }

  addIndexArringredients(str: string) {
    if (this.arringredients[this.arringredients.length - 1] != "")
      this.arringredients.push("");
  }
  addIndexArrPreparation(str: string) {
    if (this.arrPreparation[this.arrPreparation.length - 1] != "")
      this.arrPreparation.push("");
  }


  checkIfEmptyIngredient(e, i) {
    console.log(i);
    if (e.target.value == "") {
      if (i == 0)
        this.arringredients.shift();
      else if (this.arringredients.length - 3 == i)
        this.arringredients.slice();
      else
        this.arringredients.splice(i, 1);
      console.log(this.arringredients);

    }

  }
  checkIfEmptyPreparation(e, i) {
    if (e.target.value == "") {
      if (i == 0)
        this.arrPreparation.shift();
      else
        this.arrPreparation.splice(i, 1);
    }
  }

  goToRecipe(item: Recipe) {
    this.router.navigate(['listrecipe']);

  }
  alert2() {
    swal({
      title: "כל הכבוד",
      text: "!המתכון עודכן בהצלחה",
      icon: "success",
    });

  }
  ngOnInit(): void {
  }
}


