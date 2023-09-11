import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-age-data',
  templateUrl: './agedata.component.html',
})

export class AgeDataComponent {
  public AgeDatas: AgeData[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<AgeData[]>(baseUrl + 'userdata/age').subscribe(result => {
      this.AgeDatas = result;
    }, error => console.error(error));
  }
}

interface AgeData {
  id: string;
  firstName: string;
  lastName: string;
  dob: string;
}

