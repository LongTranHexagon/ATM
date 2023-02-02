# ATMapplication

TITLE Screen -- (MainTitle.cs)
Label -- Select your Card Number: (CardNumberLabel)
ComboBox -- BLANK (EnterCardList)
Button -- Submit (CardNumberSubmitBTN)
Button -- Register (RegisterBTN)

Action: 
1. Search all CardNumber and displays them in ComboBox(EnterCardList)
2. On-Click "Submit" button will take user to VerifyPIN.cs
3. On-Click "Register" button will take user to Register.cs

VERIFYPIN Screen -- 
Label -- Select your Card Number: 
Customer's Name Associated with the Card
Enter PIN Number (Need to verify if the PIN is assocaited with the Card Number)

OPTION Screen

LEFT SIDE

1. BALANCE
	a. ACCOUNT Screen -- (Accounts.cs)
		1. CHECKING Account -- (CheckBalance.cs)
			a. CHECKINGBALANCE Screen
				Customer's Name
				Checking Account Number
				Checking Account Balance

		2. SAVING Account -- (SavingBalance.cs)
			a. SAVINGSBALANCE Screen
				Customer's Name
				Saving Account Number
				Saving Account Balance
2. FAST CASH
	a. FAST CASH Screen
			LEFT Side "CHECKING"
			1. $20
				DISPENSING Screen...
					Remainding Balance: 
			2. $40
				DISPENSING Screen...
					Remainding Balance:
			3. $60
				DISPENSING Screen...
					Remainding Balance:
			4. $100
				DISPENSING Screen...
					Remainding Balance:
			RIGHT side "SAVINGS
			5. $20
				DISPENSING Screen...
					Remainding Balance: 
			6. $40
				DISPENSING Screen...
					Remainding Balance:
			7. $60
				DISPENSING Screen...
					Remainding Balance:
			8. $100
				DISPENSING Screen...
					Remainding Balance:
3. WITHDRAW
	a. ACCOUNT Screen -- (Accounts.cs)
		1. WITHDRAWCHECKING Account
			a. WITHDRAWCHECKING Screen
				Customer's Name
				Checking Account Number
				Checking Account Balance
				Withdraw Amount:
					b. DISPENSING Screen...
						Remainding Balance:
						1. Exit ATM
						2. Another Transaction
		2. WITHDRAWSAVING Account
			a. WITHDRAWSAVINGS Screen
				Customer's Name
				Saving Account Number
				Saving Account 
				Withdraw Amount: 
					b. DISPENSING Screen...
						Remainding Balance
						1. Exit ATM
						2. Another Transaction
4. DEPOSIT
	a. ACCOUNT Screen -- (Accounts.cs)
		1. DEPOSITCHECKING Account
			a. ADDCHECKING Screen
				Customer's Name
				Checking Account Number
				Checking Account Balance
				Deposit Amount:
					b. ADDING Screen...
						Remainding Balance:
						1. Exit ATM
						2. Another Transaction
		2. DEPOSITSAVING Account
			a. ADDSAVINGS Screen
				Customer's Name
				Saving Account Number
				Saving Account 
				Deposit Amount: 
					b. DISPENSING Screen...
						Remainding Balance
						1. Exit ATM
						2. Another Transaction

RIGHT SIDE

5. LAST 5 
	a. ACCOUNT Screen -- (Accounts.cs)
		1. CHECKING
			a. LAST5 Screen
				1. RETURN Screen
		2. SAVINGS
			a. LAST5 
				1. RETURN Screen
			
6. BANK STATEMENT
	a. ACCOUNT -- (Accounts.cs)
		1. CHECKING
			a. STATEMENT Screen
				1. RETURN Screen
		2. SAVINGS
			a. STATEMENT Screen
				1. RETURN Screen
	
7. CHANGE PIN Number
	a. CHANGEPIN Screen
		Customer's Name
		Card Number
		PIN Number
		Change PIN: 
			1. RETURN Screen
			
8. ADD PHONE NUMBER
	a. ADDPHONE Screen
		Customer's Name
		Phone Number:
		Change Phone Number: 
			1. RETURN Screen

TOTAL Estimate 28-30 Screens

DATABASE Diagram

Customer:
CustomerID
First Name
Last Name
Phone Number

Card:
CustomerID
CardID
CardNumber
PINNumber

Account:
CardID
AccountID
AccountType
AccountBalance
AccountTransaction

Statement:
AccountID

