import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { StepperModComponent } from './stepper-mod.component';

describe('StepperModComponent', () => {
  let component: StepperModComponent;
  let fixture: ComponentFixture<StepperModComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ StepperModComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(StepperModComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
