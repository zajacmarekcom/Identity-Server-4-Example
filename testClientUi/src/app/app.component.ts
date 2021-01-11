import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { OidcSecurityService } from 'angular-auth-oidc-client';
import { AuthService } from './auth/auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'testClientUi';

  constructor(public authService: AuthService, private router: Router,
    private httpClient: HttpClient) {
  }

  ngOnInit() {
    this.authService.getUser().then((user) => {
      console.log(user);
      if (!user) {
        this.authService.login();
      }
    });
  }

  login() {
    this.router.navigate(['/login']);
  }

  sendRequest(): void {
    this.httpClient.get('https://localhost:5101/api/home').subscribe(() => {
      console.log('hello');
    });
  }
}
