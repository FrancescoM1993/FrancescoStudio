export interface User {
    id: number;
    name: string;
    address: Address;
}

export interface Address {
    citta: string;
    via: string;
    cap: string;
}
