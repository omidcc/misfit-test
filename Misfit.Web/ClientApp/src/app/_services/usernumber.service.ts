import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from "rxjs";
import { Result } from '../_models/Result';

@Injectable({
  providedIn: 'root'
})
export class UsernumberService {

  constructor(private http: HttpClient) { }

  saveUserResult(result: Result): Observable<Result> {
    console.log(result);
    return this.http.post<Result>('/api/v1/misfit/result', result);
  }

  getAllResults() {
    return this.http.get<Result[]>('/api/v1/misfit/results');

  }

 
}
