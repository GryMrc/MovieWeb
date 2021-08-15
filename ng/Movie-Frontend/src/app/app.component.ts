import { Component, Injectable, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from './model/user.model';
import { ServiceResponse } from './model/serviceResponse.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

@Injectable()
export class AppComponent implements OnInit {
  user : User = new User();
  response : ServiceResponse = new ServiceResponse();
  
  constructor(private httpClient: HttpClient){
    
  }

 ngOnInit(){

 }

  httpRequest(){
    this.httpClient.post<ServiceResponse>("http://localhost:5869/api/Authenticate/Login",this.user).subscribe(result => {
     console.log(result);
  })
}

}
