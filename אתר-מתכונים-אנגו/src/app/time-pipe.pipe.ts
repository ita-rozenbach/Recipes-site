import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'timePipe'
})
export class TimePipePipe implements PipeTransform {

  
  transform(time): unknown {
    return Math.floor(time / 60) + ":" + time % 60;
  }

}



