export interface Purchase {
    id?: number;
    userId: number;
    productId: number;
    quantity: number;
    purchaseDate: Date;
}

export interface PurchaseDTO {
    id?: number;
    userName: string;
    productName: string;
    quantity: number;
    purchaseDate: string;
}