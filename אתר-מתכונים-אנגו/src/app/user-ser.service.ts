import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from 'src/modals/User';


@Injectable({
  providedIn: 'root'
})
export class UserSerService {

  flag: boolean = false;

  // ifExistName(name: string) {
  //   return this.http.get<boolean>("http://localhost:4300/api/User/ifExist?name=" + name);
  // }

  // ifExistNamePassword(name: string, password: string) {
  //   return this.http.get<User>("http://localhost:4300/api/User/ifExist?name=" + name + "&password=" + password);
  // }

  addUser(u: User) {
    this.updateCurentUser(u)
    return this.http.post<boolean>("http://localhost:4300/api/User/AddUser", u);
  }

  getAllUser() {
    return this.http.get<Array<User>>("http://localhost:4300/api/User/getAllUsers");
  }

  updateCurentUser(u: User) {
    sessionStorage.setItem("user", JSON.stringify(u));
  }

  getFlag() {
    if (sessionStorage.getItem('user') == 'null'){
      return false;}
    return true;
  }
  constructor(public http: HttpClient) {
    
  }
}
