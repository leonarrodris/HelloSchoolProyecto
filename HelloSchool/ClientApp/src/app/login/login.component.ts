import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor() { }

  $('.toggle').on('click', function() {
    $('.container').stop().addClass('active');
  });
  
  $('.close').on('click', function() {
    $('.container').stop().removeClass('active');
  });
  
  ngOnInit() {
  }

}
