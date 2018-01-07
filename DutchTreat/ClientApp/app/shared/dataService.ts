
import { Injectable } from "@angular/core";
import { Http, Response } from "@angular/http";
import { Observable } from "rxjs";
import { Product } from "./product";
import 'rxjs/add/operator/map';



@Injectable()
export class DataService {
    constructor(private http: Http) {}
    public products: Product[] = [];

    public loadProducts(): Observable<Product[]> {
        return this.http.get("/api/products")
            .map((result: Response) => this.products = result.json());
    }
}