import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { OidcSecurityService } from 'angular-auth-oidc-client';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'testClientUi';

  constructor(public authService: OidcSecurityService, private router: Router) {

  }

  ngOnInit() {
    this.authService.checkAuth().subscribe((auth) => {
      console.log(auth);
      if (!auth) {
        //this.login();
      }
    });
  }

  login() {
    this.router.navigate(['/login']);
  }
}
