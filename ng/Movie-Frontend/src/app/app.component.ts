import { Component, Injectable, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from './model/user.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

@Injectable()
export class AppComponent implements OnInit {
  title : User = new User();
  
  constructor(private httpClient: HttpClient){
    
  }

 ngOnInit(){

 }

  httpRequest(){
    this.httpClient.post("http://localhost:5869/api/Authenticate/Register",this.title).subscribe(result => {
     console.log(result.toString());
  })
}

}
