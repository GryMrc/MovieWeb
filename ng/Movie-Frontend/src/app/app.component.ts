import { Component, Injectable, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

@Injectable()
export class AppComponent implements OnInit {
  title : string = 'no connection was found';
  

  constructor(private httpClient: HttpClient){
    
  }

 ngOnInit(){

 }

  httpRequest(){
    this.httpClient.get("https://localhost:44339/api/Movie/Create",{responseType : 'text'}).subscribe(result => {
   this.title = result;    
  })
}

}
