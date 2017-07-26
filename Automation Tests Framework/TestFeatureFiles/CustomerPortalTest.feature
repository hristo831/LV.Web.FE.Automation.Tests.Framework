Feature: CustomerPortal main functionalities tests 

Background: Go to file
	Given Go to Login Page
	And Login
	And Enter file number in the universal SearchBox
	When Select file
	Then The user should be at the selected file page
	Given Go to the Required Documents page
	And Add a new Required Document
	And Select document
	And Enter Statement Date
	And Check On Portal checkbox
	And Click Party Link


Scenario Outline: Validation whether the customer has a registered email in LoanVantage

	Given Select Party that has not a registered email in Loanvantage
	And Click Save
	And Click Save to create a new Required Document
	Then Validation message pop up


Scenario Outline: Validation whether the registered customer email in Loanvantage is already registered in CustomerPortal

	Given Select Party that has registered an email in Loanvantage already registered in CustomerPortal
	And Click Save
	And Click Save to create a new Required Document
	Then Validation message pop up


Scenario Outline: Sent Required Document from LoanVantage to CustomerPortal
	Given Select Party that has a valid registered email in LoanVantage
	And Click Save
	And Click Save to create a new Required Document 
	And Click Email to sent an email to the Customer
	And Click Sent
	Then The Customer has received an email
	Given Click on the received link
	And Login to the CustomerPortal
	Then The Customer should have received the Required Document
	Given Upload the Required Document 
	And Click Confirm
	Then The Required Document should be sent from CustomerPortal
	Then The Required Document should be received to LoanVantage


