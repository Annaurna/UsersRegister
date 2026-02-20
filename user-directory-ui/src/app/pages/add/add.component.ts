import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { CommonModule } from '@angular/common';
import { UserService } from '../../services/user.service';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { User } from '../../models/User'; // Adjust path if needed


//import { User } from '../../models/User'; // Adjust path if needed
import { FetchBackend } from '@angular/common/http';


@Component({
  selector: 'app-add',
  imports: [FormsModule,CommonModule],
  templateUrl: './add.component.html',
  styleUrls: ['./add.component.css']
})
export class AddComponent {
  user = {
    name: '',
    age: 0,
    city: '',
    state: '',
    pincode: '',
  };
users : User[] = [];
  constructor(
    private userService: UserService,
    private router: Router,
  ) {}


  submit() { 
    this.userService.addUser(this.user).subscribe({ 
      next: (response) => { 
        //this.successMessage = response.message; // "Successfully Created"

        console.log(response.message); 
        
        
        this.router.navigate(['/list'], { onSameUrlNavigation: 'reload' });
        alert("User added Successfully");
        return false;
      },
       error: (err) => { console.error('Error adding user:', err); } }); }
  
}
