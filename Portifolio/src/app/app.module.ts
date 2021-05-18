/* Imports do sistema */
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';

/* Imports componentes |  */
import { AppComponent } from './app.component';
import { MenuPrincipalComponent } from './toolbar/menu-principal/menu-principal.component';
import { InitialComponent } from './pages/initial/initial.component';
import { WorksComponent } from './pages/works/works.component';
import { ContactComponent } from './pages/contact/contact.component';
import { rotaApp } from './routes/app.routes';
import { NotFoundComponent } from './pages/not-found/not-found.component';
import { BaseLayoutComponent } from './components/base-layout/base-layout.component';
import { SiteLayoutComponent } from './components/site-layout/site-layout.component';
import { MenuServiceService } from './services/menu/menu-service.service';
import { LoginModule } from './pages/login/login.module';
import { DirectivesModuleModule } from './directives/directives-module.module';
import { CardLayoutComponent } from './components/card-layout/card-layout.component';
import { FooterComponent } from './footer/footer/footer.component';
import { WorkServiceService } from './services/works/work-service.service';
import { DetailWorkComponent } from './pages/detail-work/detail-work.component';
import { CarrouselWorkModule } from './components/carrousel-work/carrousel-work.module';
import { DetailWorkService } from './services/detail-work/detail-work.service';
import { LoadingModule } from './components/loading/loading.module';
import { ReactiveFormsModule } from '@angular/forms';
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
    
  
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    rotaApp,
    HttpClientModule,
    LoginModule,
    DirectivesModuleModule,
    CarrouselWorkModule,
    LoadingModule

  ],
  providers: [
    MenuServiceService,
    WorkServiceService,
    DetailWorkService
  ],
  bootstrap: [AppComponent]
}) 
export class AppModule { }
