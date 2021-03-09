export class Recipe {
    constructor(
        public codeRecipe:number,
        public nameRecipe:string, 
        public codeCategory:number,
         public timeAtMinute:number,
        public LevelDifficulty:number,
        public  addRecipe: Date,
        public ingredients:string,
        public Preparation:string,
        public userCode:number,
        public image:string,
        public isShow:boolean){}
}