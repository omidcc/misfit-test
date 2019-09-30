import { Component, OnInit } from '@angular/core';
import { Result } from '../_models/result';
import { User } from '../_models/user';
import { UsernumberService } from '../_services/usernumber.service';

@Component({
  selector: 'app-add-number',
  templateUrl: './add-number.component.html',
  styleUrls: ['./add-number.component.css']
})
export class AddNumberComponent implements OnInit {

  result: Result = new Result();
  user: User = new User();
  isValid: boolean = true;
  validationClass: string = "needs-validation";
  loadClass: string = "d-none";
  showLoader: boolean = false;

  constructor(private usernumberService: UsernumberService) { }

  ngOnInit() {
  }

  saveUserResult() {
    if (this.validate()) {
      this.toggleLoader();
      this.result.user = this.user;
      this.usernumberService.saveUserResult(this.result).subscribe(result => {
        this.resetData();
        this.toggleLoader();
        alert("Result added successfully");
      });
    }
    else {
      return false;
    }
  }

  validate() {
    this.isValid = (!this.result.firstNumber || !this.result.secondNumber || !this.user.userName) ? false : true;
    this.validationClass = this.isValid ? "needs-validation" : "was-validated";
    return this.isValid;
  }

  resetData() {
    this.result = new Result();
    this.user = new User();
  }
  toggleLoader() {
    this.showLoader = !this.showLoader;
    this.loadClass = this.showLoader ? "d-block" : "d-none";
  }
}
