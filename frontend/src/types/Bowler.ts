export type Bowler = {
  team: any;
  bowlerId: number;
  bowlerLastName: string;
  bowlerFirstName: string;
  bowlerMiddleInit: string;
  bowlerAddress: string;
  bowlerCity: string;
  bowlerState: string;
  bowlerZip: string;
  bowlerPhoneNumber: string;
  teamId: number;
  teamName: Team;
};

export type Team = {
  teamId: number;
  teamName: string;
  captainId: number;
};
