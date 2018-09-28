import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HomePageComponent } from './home/home.page';
import { SignInPageComponent } from './signin/signin.page';

@NgModule({
  declarations: [
    HomePageComponent,
    SignInPageComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    HomePageComponent,
    SignInPageComponent
  ]
})
export class PagesModule { }
