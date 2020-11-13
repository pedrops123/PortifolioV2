import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MenuPrincipalComponent } from './toolbar/menu-principal/menu-principal.component';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatButtonModule } from '@angular/material/button';
import { InitialComponent } from './pages/initial/initial.component';
import { WorksComponent } from './pages/works/works.component';
import { ContactComponent } from './pages/contact/contact.component';
import { rotaApp } from './routes/app.routes';
import { NotFoundComponent } from './pages/not-found/not-found.component';

import { BaseLayoutComponent } from './components/base-layout/base-layout.component';
import { SiteLayoutComponent } from './components/site-layout/site-layout.component';
import { MatIconModule } from '@angular/material/icon';

import { FormLoginComponent } from './pages/login/form-login/form-login.component';
import { MenuServiceService } from './services/menu/menu-service.service';
import { HttpClientModule } from '@angular/common/http';
import { MatInputModule } from '@angular/material/input';
import { LoginModule } from './pages/login/login.module';
import { DirectivesModuleModule } from './directives/directives-module.module';
import { MatCardModule } from '@angular/material/card';
import { CardLayoutComponent } from './components/card-layout/card-layout.component';
import {MatPaginatorModule} from '@angular/material/paginator';
import { FooterComponent } from './footer/footer/footer.component';
import {MatMenuModule} from '@angular/material/menu';
import {MatTooltipModule} from '@angular/material/tooltip';
import { WorkServiceService } from './services/works/work-service.service';
import { DetailWorkComponent } from './pages/detail-work/detail-work.component';
import { CarrouselWorkComponent } from './components/carrousel-work/carrousel-work.component';



@NgModule({
  declarations: [
    AppComponent,
    MenuPrincipalComponent,
    InitialComponent,
    WorksComponent,
    ContactComponent,
    NotFoundComponent,
    BaseLayoutComponent,
    SiteLayoutComponent,
    CardLayoutComponent,
    FooterComponent,
    DetailWorkComponent,
    CarrouselWorkComponent,
    
    
   
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    rotaApp,
    MatToolbarModule,
    MatGridListModule,
    MatButtonModule,
    MatIconModule,
    HttpClientModule,
    MatInputModule,
    LoginModule,
    DirectivesModuleModule,
    MatCardModule,
    MatPaginatorModule,
    MatMenuModule,
    MatTooltipModule

  ],
  providers: [
    MenuServiceService,
    WorkServiceService
  ],
  bootstrap: [AppComponent]
}) 
export class AppModule { }
