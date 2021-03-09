import { Component, OnInit } from '@angular/core';
import { CategoryService } from '../category.service';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {
  mail: string;
  name:string;
  sub:string;
  flag:boolean;
  constructor(public categorySer:CategoryService) { }
  sendMail(sub:string, body:string){
    this.categorySer.sendMail(sub, body).subscribe(p=>console.log("sent the mail"), err=>console.log("cant sent"));
  }
  clear(){
    this.mail='';
    this.sub='';
    this.name='';
  }

  ngOnInit(): void {
  }

}
