/* Imports do sistema */
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClient, HttpClientModule } from '@angular/common/http';

/* Imports componentes |  */
import { AppComponent } from './app.component';
import { MenuPrincipalComponent } from './toolbar/menu-principal/menu-principal.component';
import { InitialComponent } from './pages/initial/initial.component';
import { WorksComponent } from './pages/works/works.component';
import { ContactComponent } from './pages/contact/contact.component';
import { rotaApp } from './routes/app.routes';
import { NotFoundComponent } from './pages/not-found/not-found.component';
import { MenuServiceService } from './services/menu/menu-service.service';
import { LoginModule } from './pages/login/login.module';
import { DirectivesModuleModule } from './directives/directives-module.module';
import { FooterComponent } from './footer/footer/footer.component';
import { WorkServiceService } from './services/works/work-service.service';
import { DetailWorkComponent } from './pages/detail-work/detail-work.component';
import { DetailWorkService } from './services/detail-work/detail-work.service';
import { ReactiveFormsModule } from '@angular/forms';
import { ComponentsModule } from './components/components.module';
import { TranslateLoader, TranslateModule } from '@ngx-translate/core';
import { TranslateHttpLoader } from '@ngx-translate/http-loader';
import { ServicesModule } from './services/services.module';
import { fader } from './routes/route-animations';
@NgModule({
  declarations: [
    AppComponent,
    MenuPrincipalComponent,
    InitialComponent,
    WorksComponent,
    ContactComponent,
    NotFoundComponent,
    FooterComponent,
    DetailWorkComponent,
    
  
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    ServicesModule,
    BrowserAnimationsModule,
    rotaApp,
    HttpClientModule,
    LoginModule,
    DirectivesModuleModule,
    ComponentsModule,
    TranslateModule.forRoot({
      loader: {
          provide: TranslateLoader,
          useFactory: HttpLoaderFactory,
          deps: [HttpClient]
      },
  })
  ],
  bootstrap: [AppComponent]
}) 
export class AppModule { }

export function HttpLoaderFactory(http: HttpClient): TranslateHttpLoader {
  return new TranslateHttpLoader(http);
}