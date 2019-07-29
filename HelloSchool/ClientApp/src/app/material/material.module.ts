import { NgModule } from '@angular/core';
import {MatButtonModule, 
  MatToolbarModule, 
  MatSidenavModule,
  MatTabsModule, MatMenuModule,
  MatStepperModule,
  MatInputModule,
  MatAutocompleteModule,
  MatSelectModule,MatDatepickerModule,MatNativeDateModule, 
  
} from '@angular/material';

const material=[MatButtonModule,MatSelectModule, MatToolbarModule,MatSidenavModule,MatTabsModule, MatMenuModule,MatStepperModule,
  MatInputModule,
  MatAutocompleteModule,MatDatepickerModule,MatNativeDateModule, ];
@NgModule({
  declarations: [],
  imports: [
   material
  ], 
  exports: [
   material
  ]
})
export class MaterialModule { }