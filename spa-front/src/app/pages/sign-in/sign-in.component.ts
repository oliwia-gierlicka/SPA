import { Component } from '@angular/core';
import { EmailValidator, FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.scss']
})
export class SignInComponent {
  option = 0

  signInForm = new FormGroup({
    login: new FormControl(''),
    password: new FormControl('')
  })

  signUpFrom=new FormGroup({
    firstname:new FormControl(''),
    lastname: new FormControl(''),
    email: new FormControl(''),
    login:new FormControl(''),
    password: new FormControl('')
})

  change(newoption: number) {
    this.option = newoption
  }

  signIn() {
    console.log(this.signInForm.value)
  }
}
