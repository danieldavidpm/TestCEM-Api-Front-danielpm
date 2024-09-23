import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class DocumenttypeService {

  constructor(private http: HttpClient) {}

	ListCbo(): Observable<DocumentType[]> {
		const uri = `${environment.pathLibeyTechnicalTest}DocumentType/`;
		return this.http.get<DocumentType[]>(uri);
	}
}
