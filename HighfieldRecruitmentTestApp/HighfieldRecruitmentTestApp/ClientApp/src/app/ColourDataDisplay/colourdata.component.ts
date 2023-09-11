import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-colour-data',
  templateUrl: './colourdata.component.html',
})

export class ColourDataComponent {
  public colourDatas: colourData[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<colourData[]>(baseUrl + 'userdata/colour').subscribe(result => {
      this.colourDatas = result;
    }, error => console.error(error));
  }
}

interface colourData {
  ColourName: string;
  Quantity: string;
}

