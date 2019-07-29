import {Component, OnInit} from '@angular/core';
import {FormBuilder, FormGroup, Validators} from '@angular/forms';
import {MaterialModule} from '../material/material.module';
@Component({
  selector: 'app-stepper-mod',
  templateUrl: './stepper-mod.component.html',
  styleUrls: ['./stepper-mod.component.css']
})
export class StepperModComponent implements OnInit {
  imports: [MaterialModule];
  firstFormGroup: FormGroup;
  secondFormGroup: FormGroup;
  isOptional = false;

  constructor(private _formBuilder: FormBuilder) {}

  ngOnInit() {
    this.firstFormGroup = this._formBuilder.group({
      firstCtrl: ['', Validators.required]
    });
    this.secondFormGroup = this._formBuilder.group({
      secondCtrl: ''
    });
  }
}
