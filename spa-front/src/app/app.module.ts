import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './pages/home/home.component';
import { WelcomeSectionComponent } from './components/welcome-section/welcome-section.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { TransparentButtonComponent } from './components/transparent-button/transparent-button.component';
import { AboutComponent } from './components/about/about.component';
import { ServicesComponent } from './components/services/services.component';
import { ServiceItemComponent } from './components/service-item/service-item.component';
import { ProductsSectionComponent } from './components/products/products.component';
import { ReviewsComponent } from './components/reviews/reviews.component';
import { ReviewItemComponent } from './components/review-item/review-item.component';
import { ContactComponent } from './components/contact/contact.component';
import { BackComponent } from './components/back/back.component';
import { FitnessComponent } from './pages/fitness/fitness.component';
import { TabsComponent } from './components/tabs/tabs.component';
import { TabItemComponent } from './components/tab-item/tab-item.component';
import { ProductsComponent } from './pages/products/products.component';
import { HttpClientModule } from '@angular/common/http';
import { SignInComponent } from './pages/sign-in/sign-in.component';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    WelcomeSectionComponent,
    NavbarComponent,
    TransparentButtonComponent,
    AboutComponent,
    ServicesComponent,
    ServiceItemComponent,
    ProductsSectionComponent,
    ReviewsComponent,
    ReviewItemComponent,
    ContactComponent,
    BackComponent,
    FitnessComponent,
    TabsComponent,
    TabItemComponent,
    ProductsComponent,
    SignInComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
