import { Component, OnInit } from '@angular/core';
import { LibeyUserService } from 'src/app/core/service/libeyuser/libeyuser.service';

@Component({
  selector: 'app-userlist',
  templateUrl: './userlist.component.html',
  styleUrls: ['./userlist.component.css']
})
export class UserlistComponent implements OnInit {

  constructor(private libeyUserService: LibeyUserService) { }

  
  ngOnInit(): void {
    this.getListaUsuarios();
  }
  
  listaUsuarios: any[] = [];
  getListaUsuarios(){
    this.libeyUserService.ListUser().subscribe((x) => {
      this.listaUsuarios = x
      console.log(this.listaUsuarios);
    })
  }

}
