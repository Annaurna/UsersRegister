import { Component, OnInit } from '@angular/core';
import { UserService } from '../../services/user.service';
import { CommonModule } from '@angular/common';
import { User } from '../../models/User'; // Adjust path if needed
import { Observable } from 'rxjs';
import { Router, NavigationEnd } from '@angular/router';

@Component({
  selector: 'app-list',
  imports: [CommonModule],
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})
export class ListComponent implements OnInit {

    users : User[] = [];
  errorMessage: string = '';


  constructor(private userService: UserService,private router : Router) {}

  ngOnInit(): void {
    this.loadUsers();

    
    
  

  }



  

  loadUsers() {

  this.userService.getUser().subscribe({
      next: (data) => {


        this.users = data;
        console.log('User data:', this.users);
      },
      error: (error) => {
        this.errorMessage = 'Failed to fetch user';
        console.error('Error fetching user:', error);
      }
    });
  }

  
  delete(id: number): void 
  { if (confirm('Are you sure you want to delete this user?')) 
    { 
      this.users = this.users.filter(user => user.id !== id);
      this.userService.deleteUser(id).
      subscribe(() => { 
        // Refresh list after deletion 
      this.loadUsers();
    alert("User deleted Successfully");
        return false;

    }); } }


}
