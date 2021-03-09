import { Component, OnInit } from '@angular/core';
import { UserSerService } from '../user-ser.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {
  constructor(public userService: UserSerService) {

  }
  getClass() {
    return this.userService.getFlag();
  }
  ngOnInit(): void {
  }

  func() {
    console.log("sdfaf");
  }
}
