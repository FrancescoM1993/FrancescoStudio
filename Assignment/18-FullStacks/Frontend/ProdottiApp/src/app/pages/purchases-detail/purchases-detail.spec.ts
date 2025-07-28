import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PurchasesDetail } from './purchases-detail';

describe('PurchasesDetail', () => {
  let component: PurchasesDetail;
  let fixture: ComponentFixture<PurchasesDetail>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PurchasesDetail]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PurchasesDetail);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
