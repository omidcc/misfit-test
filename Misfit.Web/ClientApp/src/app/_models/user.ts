import { Result } from "./Result";


export class User {
  id: number;
  userName: string;
  results: Array<Result>;

  public constructor(init?: Partial<User>) {
    Object.assign(this, init);
  }
}
