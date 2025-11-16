## Payslip Project

### Specs
This project is written using the .Net 9.0 framework.

### Details
Payslip created to calculate the employees monthly payslip.

##### Employee Attributes
- Name
- Annual Salary

##### Payslip Attributes
- Name
- Gross monthly income = annaual salary / 12 (months)
- Monthly income tax = (annual tax rate rate as below) / 12 (months)
- Net monthly income = gross monthly income - monthly income tax

##### Tax Rates
Taxable Income | Tax Rate
- 0 - $20,000 | 0%
- $20,001 - $40,000 | 10c for every $1 over $20,000
- $40,001 - $80,000 | $2,000 + 20c for every $1 over $40,000
- $80,001 - $180,000 | $10,000 + 30c for every $1 over $80,000
- $180,001 and over | $40,000 + 40c for every $1 over $180,000

##### Example
For an employee with an annual salary of $60,000:
- Gross monthly income = $60,000 / 12 = $5,000
- monthly income tax
- = ((20,000 * 0) + ((40,000 - 20,000) * 0.1) + ((60,000 - 40,000) * 0.2)) / 12
- = (0 + (20,000 * 0.1) + (20,000 * 0.2)) / 12
- = (0 + 2,000 + 4.000) / 12
- = 500


- net monthly income
- = 5,000 - 500 = 4,500


##### Example Input
- "Mary Song", 60000

##### Example Output
- Monthly Payslip for "Mary Song"
- Gross Monthly Income: $5000
- Monthly Income Tax: $500
- Net Monthly Income: $4500
