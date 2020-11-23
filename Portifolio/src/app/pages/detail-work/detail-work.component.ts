import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AppComponent } from 'src/app/app.component';

@Component({
  selector: 'work-detail',
  templateUrl: './detail-work.component.html',
  styleUrls: ['./detail-work.component.css']
})
export class DetailWorkComponent implements OnInit {

  idProjeto:any;
  constructor(private route: ActivatedRoute ,private principal:AppComponent) {
      this.idProjeto = this.route.snapshot.paramMap.get('idWork');
      principal.scrollToTop();
   }

  ngOnInit(): void {
  }

}
