import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Result } from '../_models/Result';
import { UsernumberService } from '../_services/usernumber.service';
import { error } from 'protractor';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {

  constructor(private usernumberService: UsernumberService) {
    
  }
  ngOnInit() {
    this.usernumberService.getAllResults().subscribe(result => {
      console.log(result);
    }, error => {
        console.log(error);
      });
  }
}
