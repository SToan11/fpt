#include <stdio.h>

int main() {
    float electricityUsage, billAmount;
    int tier1 = 1678, tier2 = 1734, tier3 = 2014, tier4 = 2536, tier5 = 2834, tier6 = 2927;

    printf("Enter electricity usage (kWh): ");
    scanf("%f", &electricityUsage);

    if (electricityUsage < 0) {
        printf("Please enter a valid electricity usage.\nElectricity usage cannot be negative.\n");
    } else if (electricityUsage <= 50) {
        billAmount = electricityUsage * tier1;
        printf("Total bill amount: $%.2f\n", billAmount);
    } else if (electricityUsage <= 100) {
        billAmount = 50 * tier1 + ((electricityUsage - 50) * tier2);
        printf("Total bill amount: $%.2f\n", billAmount);
    } else if (electricityUsage <= 200) {
        billAmount = 50 * tier1 + 50 * tier2 + ((electricityUsage - 100) * tier3);
        printf("Total bill amount: $%.2f\n", billAmount);
    } else if (electricityUsage <= 300) {
        billAmount = 50 * tier1 + 50 * tier2 + 100 * tier3 + ((electricityUsage - 200) * tier4);
        printf("Total bill amount: $%.2f\n", billAmount);
    } else if (electricityUsage <= 400) {
        billAmount = 50 * tier1 + 50 * tier2 + 100 * tier3 + 100 * tier4 + ((electricityUsage - 300) * tier5);
        printf("Total bill amount: $%.2f\n", billAmount);
    } else if (electricityUsage > 400) {
        billAmount = 50 * tier1 + 50 * tier2 + 100 * tier3 + 100 * tier4 + 100 * tier5 + ((electricityUsage - 400) * tier6);
        printf("Total bill amount: $%.2f\n", billAmount);
    }

    return 0;
}
