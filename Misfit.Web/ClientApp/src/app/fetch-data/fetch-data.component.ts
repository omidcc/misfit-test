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
  loadClass: string = "d-none";
  showLoader: boolean = false;

  columnDefs = [
    { headerName: 'First Number', field: 'firstNumber', sortable: true, filter: false },
    { headerName: 'Second Number', field: 'secondNumber', sortable: true, filter: false },
    { headerName: 'Sum', field: 'sum', sortable: true, filter: false },
    {
      headerName: 'Date', field: 'dateOfCalculation', sortable: true, filter: "agTextColumnFilter", filterParams: {
        clearButton: true,
        applyButton: true,
        debounceMs: 200
      }
    },
    {
      headerName: 'User', field: 'user.userName', sortable: true, filter: "agTextColumnFilter", filterParams: {
        clearButton: true,
        applyButton: true,
        debounceMs: 200
      }
     },
  ];

  rowData = [];

  constructor(private usernumberService: UsernumberService) {
    
  }
  ngOnInit() {
    this.toggleLoader();
    this.usernumberService.getAllResults().subscribe(result => {
      console.log(result);
      result.forEach((item) => {
        item.dateOfCalculation = item.dateOfCalculation.substring(0,10);
      });
      this.rowData = result;
      this.toggleLoader();
    }, error => {
        console.log(error);
        this.toggleLoader();
      });
    
  }

  toggleLoader() {
    this.showLoader = !this.showLoader;
    this.loadClass = this.showLoader ? "d-block" : "d-none";
  }
}
