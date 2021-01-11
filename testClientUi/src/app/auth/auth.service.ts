import { Injectable } from "@angular/core";
import { User, UserManager } from "oidc-client"

@Injectable({
    providedIn: 'root'
  })
  export class AuthService {
      userManager: UserManager;


      constructor() {
          const settings = {
              authority: 'https://localhost:5001/',
              client_id: 'testClient',
              redirect_uri: 'http://localhost:4200/assets/callback.html',
              silent_redirect_uri: 'http://localhost:4200/assets/renew-callback.html',
              response_type: 'token',
              filterProtocolClaims: true,
              scope: 'invoices.read invoices.write',
              loadUserInfo: true
          };

          this.userManager = new UserManager(settings);
      }

      public login() {
          this.userManager.signinRedirect();
      }

      public getUser(): Promise<User> {
          return this.userManager.getUser();
      }
  }