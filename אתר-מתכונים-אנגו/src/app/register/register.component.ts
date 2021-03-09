import { Component, Input, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { UserSerService } from '../user-ser.service';
// import {NgForm} from '@angular/forms';
import { User } from 'src/modals/User';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit, OnDestroy {
  subscription: Subscription = null;
  subscription1: Subscription = null;
  name: string = "";
  constructor(public userSer: UserSerService, public active: ActivatedRoute, public router: Router) {
    active.params.subscribe(param => {
      // console.log(param);
      this.name = param["name"];
    }, err => { })
  }

  mail: string;
  address: string = "";
  password: string;

  addUser() {
    this.subscription1 = this.userSer.addUser(new User(0, this.name, this.address, this.mail, this.password)).subscribe(p => { if (p == true) console.log("נוסף בהצלחה"); this.changeRoutingToRecipe() }, err => console.log(err))
    this.subscription = this.userSer.getAllUser().subscribe(p => console.log(p), err => console.log(err))

  }

  // sendForm(m) { 
  //   console.log("finish")
  // }

  changeRoutingToRecipe() {
    this.userSer.flag = true;
    this.router.navigate(['listrecipe']);
  }
  ngOnInit(): void {
  }

  ngOnDestroy(): void {
    if (this.subscription)
      this.subscription.unsubscribe();
    if (this.subscription1)
      this.subscription.unsubscribe();
  }
}
