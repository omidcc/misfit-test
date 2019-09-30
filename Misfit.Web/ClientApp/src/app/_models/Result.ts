import { User } from "./user";


export class Result {
  id: number;
  firstNumber: string;
  secondNumber: string;
  sum: string;
  dateOfCalculation: string;
  user: User;
  username: string;

  public constructor(init?: Partial<Result>) {
    Object.assign(this, init);
  }
}
