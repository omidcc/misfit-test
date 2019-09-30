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
  columnDefs = [
    { headerName: 'First Number', field: 'firstNumber', sortable: true, filter: false },
    { headerName: 'Second Number', field: 'secondNumber', sortable: true, filter: false },
    { headerName: 'Sum', field: 'sum', sortable: true, filter: false },
    {
      headerName: 'Date', field: 'dateOfCalculation', sortable: true, filter: true,
      cellRenderer: (data) => {
        return data.value //? (new Date(data.value)).toDateString() : '';
      }
    },
    { headerName: 'User', field: 'user.userName', sortable: true, filter: true },
  ];

  rowData = [];

  constructor(private usernumberService: UsernumberService) {
    
  }
  ngOnInit() {
    this.usernumberService.getAllResults().subscribe(result => {
      console.log(result);
      this.rowData = result;
    }, error => {
        console.log(error);
      });
  }
}
