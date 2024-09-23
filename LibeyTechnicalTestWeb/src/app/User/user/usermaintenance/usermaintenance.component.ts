import swal from 'sweetalert2';
import { Component, OnInit } from '@angular/core';
import { inject } from '@angular/core/testing';
import { FormBuilder, FormGroup } from '@angular/forms';
import { LibeyUserService } from 'src/app/core/service/libeyuser/libeyuser.service';
import { DocumenttypeService } from 'src/app/core/service/documenttype/documenttype.service';
import { ProvinceService } from 'src/app/core/service/province/province.service';
import { RegionService } from 'src/app/core/service/region/region.service';
import { UbigeoService } from 'src/app/core/service/ubigeo/ubigeo.service';
@Component({
  selector: 'app-usermaintenance',
  templateUrl: './usermaintenance.component.html',
  styleUrls: ['./usermaintenance.component.css']
})
export class UsermaintenanceComponent implements OnInit {
  
  public formUser: FormGroup = this.fb.group({
    documentNumber: [''],
    documentTypeId: [1],
    name: [''],
    fathersLastName :[''],
    mothersLastName :[''],
    address :[''],
    regionCode :[''],
    provinceCode :[''],
    ubigeoCode :[''],
    phone :[''],
    email :[''],
    password :[''],
})
  router: any;

  constructor(private fb: FormBuilder,
              private documettypeService: DocumenttypeService,
              private libeyUserService: LibeyUserService,
              private provinceService: ProvinceService,
              private regionService: RegionService,
              private ubigeoService: UbigeoService
             ) { }

  //private fb = inject( FormBuilder )
  
  ngOnInit(): void {
    this.getListDocumentType();
    this.getListRegion();
  }

  listDocumentType: any[] = [];
  getListDocumentType() {      
    this.documettypeService.ListCbo().subscribe({
      next: (response) => {
        this.listDocumentType = response;
      }
    });
  }

  listProvince: any[] = [];
  getListProvince(regionCode: string) {         
    this.provinceService.ListCbo(regionCode).subscribe({
      next: (response) => {
        this.listProvince = response;
      }
    });
  }
  ProvinceCode: string = '';
  onProvinceSeleccionada(){
    this.ProvinceCode = this.formUser.get('provinceCode')?.value
    this.getListUbigeo(this.ProvinceCode);
  }

  listRegion: any[] = [];
  getListRegion() {    
    console.log('documentoID: ', this.formUser.get('documentTypeId')?.value)
    this.regionService.ListCbo().subscribe({
      next: (response) => {
        this.listRegion = response;
      }
    });
  }
  regionCode: string = '';
  onRegionSeleccionada(){
    this.regionCode = this.formUser.get('regionCode')?.value
    this.getListProvince(this.regionCode);
  }

  listUbigeo: any[] = [];
  getListUbigeo(provinceCode: string) {      
    this.ubigeoService.ListCbo(provinceCode).subscribe({
      next: (response) => {
        this.listUbigeo = response;
      }
    });
  }

  Submit(){
    this.libeyUserService.SaveUser(this.formUser.value).subscribe((x) => {
      swal.fire("Grabado correctamente...!", "Todo OK");
      this.router.navigateByUrl('/user/card');
    })
  }


}