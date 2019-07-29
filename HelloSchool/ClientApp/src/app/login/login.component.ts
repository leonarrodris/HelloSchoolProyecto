import { Component, OnInit } from '@angular/core';
import {MaterialModule} from '../material/material.module';
import * as $ from 'jquery';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  imports: [
    MaterialModule
  ];
 
  constructor() { }

  


  ngOnInit() {
    $('.toggle').on('click', function() {
      $('.container').stop().addClass('active');
    });
    $('.close').on('click', function() {
      $('.container').stop().removeClass('active');
    });
  }
}
