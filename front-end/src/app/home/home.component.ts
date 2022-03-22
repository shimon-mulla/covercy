import {AfterViewInit, Component, ViewChild} from '@angular/core';
import {RequestHandlerService} from "../request-handler.service";
import {MatButton} from "@angular/material/button";
import { PeriodicElement } from '../core/models/PeriodicElement';
import {MatTableDataSource} from '@angular/material/table';
import { SelectionModel } from '@angular/cdk/collections';
import { MatPaginator } from '@angular/material/paginator';

const DATA_FROM_SERVER = false;

const ELEMENT_DATA: PeriodicElement[] = [
  {position: 1, name: 'Hydrogen', weight: 1.0079, symbol: 'H'},
  {position: 2, name: 'Helium', weight: 4.0026, symbol: 'He'},
  {position: 3, name: 'Lithium', weight: 6.941, symbol: 'Li'},
  {position: 4, name: 'Beryllium', weight: 9.0122, symbol: 'Be'},
  {position: 5, name: 'Boron', weight: 10.811, symbol: 'B'},
  {position: 6, name: 'Carbon', weight: 12.0107, symbol: 'C'},
  {position: 7, name: 'Nitrogen', weight: 14.0067, symbol: 'N'},
  {position: 8, name: 'Oxygen', weight: 15.9994, symbol: 'O'},
  {position: 9, name: 'Fluorine', weight: 18.9984, symbol: 'F'},
  {position: 10, name: 'Neon', weight: 20.1797, symbol: 'Ne'},
];

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})

export class HomeComponent implements AfterViewInit{

  @ViewChild(MatPaginator)
  paginator!: MatPaginator;

  constructor(private requestService: RequestHandlerService) {
  }
  
  message: string = '';
  isSubmit: boolean = false
  messageStyle: string = '';
  isLoading: boolean = false;

  displayedColumns: string[] = ['select', 'position', 'name', 'weight', 'symbol'];
  dataSource = DATA_FROM_SERVER ? new MatTableDataSource<PeriodicElement>() : new MatTableDataSource<PeriodicElement>(ELEMENT_DATA);

  selection = new SelectionModel<PeriodicElement>(true, []);
  ngAfterViewInit(): void {
    this.dataSource.paginator = this.paginator;
  }

   /** Whether the number of selected elements matches the total number of rows. */
   isAllSelected() {
    const numSelected = this.selection.selected.length;
    const numRows = this.dataSource.data.length;
    return numSelected === numRows;
  }

  /** Selects all rows if they are not all selected; otherwise clear selection. */
  masterToggle() {
    if (this.isAllSelected()) {
      this.selection.clear();
      return;
    }
    this.selection.select(...this.dataSource.data);
  }

  /** The label for the checkbox on the passed row */
  checkboxLabel(row?: PeriodicElement): string {
    if (!row) {
      return `${this.isAllSelected() ? 'deselect' : 'select'} all`;
    }
    return `${this.selection.isSelected(row) ? 'deselect' : 'select'} row ${row.position + 1}`;
  }

  showInConsole(){
    console.table(this.selection.selected);
  }

  sendRequest() {
    this.message = ''
    this.isLoading = true;
    this.requestService.sendRequest()
      .subscribe(
        (res) => {
          this.isLoading = false;
          this.isSubmit = true;
          this.message = 'Success'
          this.messageStyle = 'success';
          if(DATA_FROM_SERVER){
            this.dataSource = new MatTableDataSource<PeriodicElement>(res);
            this.dataSource.paginator = this.paginator;
            console.log(res);
          }
        },
        (error) => {
          this.isLoading = false;
          this.isSubmit = true;
          this.message = 'Failed';
          this.messageStyle = 'fail'
        }
      )
  }
}
