import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})

export class HomeComponent {
  public UserDatas: UserData[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<UserData[]>(baseUrl + 'userdata').subscribe(result => {
      this.UserDatas = result;
    }, error => console.error(error));
  }
}

interface UserData {
  id: string;
  firstName: string;
  lastName: string;
  email: string;
  dob: string;
  favouriteColour: string;
}
