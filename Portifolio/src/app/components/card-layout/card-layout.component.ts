import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'card-layout-component',
  templateUrl: './card-layout.component.html',
  styleUrls: ['./card-layout.component.css']
})
export class CardLayoutComponent implements OnInit {

  @Input() idProjeto :number;
  @Input() urlFoto:string;
  @Input() description :string;
  
  constructor(private router:Router) { }

  ngOnInit(): void {
  }

  gotoDetailProject(description){
    this.router.navigate(['detail',description]);
  }

}
