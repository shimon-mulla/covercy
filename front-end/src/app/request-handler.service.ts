import {Injectable} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import { PeriodicElement } from './core/models/PeriodicElement';

@Injectable({
  providedIn: 'root'
})
export class RequestHandlerService {
  constructor(private http: HttpClient) {
  }

  sendRequest() {
    return this.http.get<PeriodicElement[]>('https://localhost:44379/api/FrontEnd')
  }
}
