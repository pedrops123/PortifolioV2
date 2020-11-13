import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'work-detail',
  templateUrl: './detail-work.component.html',
  styleUrls: ['./detail-work.component.css']
})
export class DetailWorkComponent implements OnInit {

  idProjeto:any;
  constructor(private route: ActivatedRoute) {
      this.idProjeto = this.route.snapshot.paramMap.get('idWork');
   }

  ngOnInit(): void {
  }

}
