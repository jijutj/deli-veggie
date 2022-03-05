import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { product } from 'src/app/models/product';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.scss']
})
export class ProductDetailsComponent implements OnInit {

  product: product; 
  productId: string;
  constructor(
    private productService: ProductService,
    private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.productId = String(this.route.snapshot.paramMap.get('id'));
    this.getProductDetails();
  }

  getProductDetails(){
    this.productService.getProductById(this.productId).subscribe(
      (data : product) => { 
        this.product = data;
      }
    );
  }
}
