import { NO_ERRORS_SCHEMA } from '@angular/core';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { FormsModule, NgForm } from '@angular/forms';
import { Routine } from 'src/models/routine';
import { RoutineNameComponent } from './routine-name.component';

describe('RoutineNameComponent', () =>
{
    let component: RoutineNameComponent;
    let fixture: ComponentFixture<RoutineNameComponent>;

    beforeEach(async(() =>
    {
        const options = {
            declarations: [RoutineNameComponent],
            imports: [FormsModule],
            providers: [NgForm],
            schemas: [NO_ERRORS_SCHEMA]
        };
        TestBed.configureTestingModule(options).compileComponents();
    }));

    beforeEach(() =>
    {
        fixture = TestBed.createComponent(RoutineNameComponent);
        component = fixture.componentInstance;
        component.routine = new Routine();
        fixture.detectChanges();
    });

    it('should create', () =>
    {
        expect(component).toBeTruthy();
    });
});
