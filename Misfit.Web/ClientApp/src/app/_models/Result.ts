import { User } from "./user";


export class Result {
  id: number;
  firstNumber: string;
  secondNumber: string;
  sum: string;
  dateOfCalculation: Date;
  user: User;
  username: string;

  public constructor(init?: Partial<Result>) {
    Object.assign(this, init);
  }
}
