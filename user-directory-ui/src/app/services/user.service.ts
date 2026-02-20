import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from '../models/User'; // Adjust path if needed



@Injectable({
  providedIn: 'root',
})


export class UserService {
  private apiUrl = 'https://localhost:7188/api/users';

  constructor(private http: HttpClient) {}


  // Fetch all users
  

    getUser(): Observable<User[]> {
    return this.http.get<User[]>(this.apiUrl);
  }

  addUser(user: any): Observable<{ message: string }> {
  return this.http.post<{ message: string }>(this.apiUrl, user);
}

//deleteUser(id: number): Observable<{ message: string }> {
  //return this.http.delete<{ message: string }>(`${this.apiUrl}/${id}`);
//}


  //addUser(user: any) {
    ////return this.http.post(this.apiUrl, user);
  //}

  deleteUser(id: number) {
    return this.http.delete(`${this.apiUrl}/${id}`);
  }
}
