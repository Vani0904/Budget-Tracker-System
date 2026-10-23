# User stories and Acceptance Criteria

These stories define the behaviour expected in the first usable version of the Budget Tracker.

## Shared Definitions

- All monetary amounts are recorded in GBP.
- Transaction amounts are positive; the transaction type identifies income or an expense.
- Monthly summaries use the transaction date, not the date the record was created.
- Net income means recorded income minus recorded expenses for the selected period. It does not represent a verified bank balance.
- Users can view and manage only their own transactions and budgets.

## US-01: Record an expense

As a user, I want to record an expense so that I can track my spending.

### Acceptance criteria

- I can enter an amount, transaction date, category, and description.
- The amount, transaction date, category, and description are required.
- The amount must be greater than zero and have no more than two decimal places.
- The transaction date must be a valid date.
- I can select an expense category from the available preset categories.
- Missing or invalid fields display clear validation messages.
- An invalid submission does not create a transaction or change any totals.
- A successful save creates exactly one expense associated with my account.
- While saving is in progress, repeated submission is prevented.
- After saving, I receive confirmation and can see the expense in my transaction history.
- The expense is included in the summary and category budget calculations for its transaction month.
- If saving fails, no success message is displayed, my entered values are retained, and I can retry.

## US-02: Review a monthly summary

As a user, I want to review a month so that I can understand my income and spending.

### Acceptance criteria

- The current month and year are selected by default.
- I can select a different month and year.
- The selected reporting period is clearly displayed.
- The summary includes only my transactions dated within the selected month and year.
- Total income and total expenses appear separately.
- Net income equals recorded income minus recorded expenses for the selected month.
- A month without transactions displays zero totals and a helpful empty-state message.
- Adding, editing, or deleting a transaction updates the relevant monthly totals.
- Amounts are displayed consistently in GBP with two decimal places.
- Net income is labelled clearly and is not presented as a verified bank balance.

## US-03: Find and filter transactions

As a user, I want to search and filter my transactions so that I can review specific areas of my income and spending.

### Acceptance criteria

- I can open a transaction history containing only my own records.
- Each entry displays its transaction date, description, category, type, and amount.
- Transactions are displayed in transaction-date order, newest first.
- I can filter transactions by category.
- I can filter transactions by month and year.
- I can filter transactions by type: income or expense.
- I can search transaction descriptions using a case-insensitive text search.
- Multiple active filters and the search term work together; results must match all selected conditions.
- I can see which filters are active and clear them.
- If no transactions match, I see an explanatory message and an option to clear the filters.
- If I have no transactions, I see an empty-state message with an action to add my first transaction.

## US-04: Correct or delete a transaction

As a user, I want to edit or delete an existing transaction so that my records remain accurate.

### Acceptance criteria

- I can select an edit or delete action for a transaction I own.
- Selecting edit opens a form populated with the transaction's existing values.
- I can update the amount, transaction date, category, and description.
- Edited values follow the same validation rules as transaction creation.
- Saving valid changes updates the existing transaction rather than creating another one.
- Cancelling an edit leaves the transaction unchanged.
- Before deletion, I see a confirmation prompt identifying the selected transaction.
- Cancelling deletion leaves the transaction unchanged.
- Confirming deletion removes the transaction from my active history and calculations.
- Successful edits or deletions update the relevant monthly summaries and category budget calculations.
- Moving a transaction to a different month or category updates both the old and new summaries or budgets.
- If an edit or deletion fails, I see an error message and no success confirmation.
- Attempting to edit or delete another user's transaction is denied, including through a direct request.

## US-05: Set and review a monthly category budget

As a user, I want to set a monthly budget for an expense category so that I can monitor my spending against it.

### Acceptance criteria

- I can select an expense category, month, and year.
- I can enter a budget limit in GBP.
- The budget limit must be zero or greater and have no more than two decimal places.
- Missing or invalid values display clear validation messages.
- I can have only one budget per category for a given month and year.
- If a budget already exists for the selected category and period, I can edit it rather than create a duplicate.
- A successful save stores the budget against my account.
- For each budget, I can see its category, reporting period, limit, actual spending, and remaining amount.
- Actual spending includes only my expenses in that category and reporting period.
- Income transactions do not count towards category spending.
- Remaining budget equals the budget limit minus actual spending.
- Spending above the limit displays a negative remaining amount and an explicit overspending message.
- Overspending is communicated through text, not colour alone.
- A category with a budget but no expenses shows zero spending and the full limit remaining.
- A category without a budget is labelled "No budget set" rather than treated as having a zero budget.
- Changes to relevant expenses update the displayed spending and remaining budget.
- Changing a budget limit does not change the underlying transactions.

## US-06: Sign in and access only my own records

As a registered user, I want to sign in securely so that I can access my personal transactions and budgets.

### Acceptance criteria

- I can sign in using my registered email address and password.
- Missing credentials display clear validation messages.
- Valid credentials grant access to my personal dashboard.
- Invalid credentials display a generic sign-in error without revealing whether an email address is registered.
- An unsuccessful sign-in does not grant access to protected records.
- When I am not signed in, I cannot access protected pages or retrieve protected financial data through direct requests.
- After signing in, I can access only transactions and budgets associated with my account.
- I cannot view, modify, or delete another user's records by changing a record ID or URL.
- Record ownership is determined from my authenticated identity, not a user ID supplied in a form.
- I can sign out.
- After signing out, subsequent requests to protected pages or data require authentication again.

## US-07: Record income

As a user, I want to record income so that my monthly summary reflects the money I have received.

### Acceptance criteria

- I can select income as the transaction type.
- I can enter an amount, transaction date, and description.
- These fields are required.
- The amount must be greater than zero and have no more than two decimal places.
- The transaction date must be a valid date.
- An expense category is not required for income.
- Missing or invalid fields display clear validation messages.
- An invalid submission does not create a transaction or change any totals.
- A successful save creates exactly one income transaction associated with my account.
- While saving is in progress, repeated submission is prevented.
- The income appears in my transaction history and the appropriate monthly summary.
- Income increases the selected month's income total but does not count towards expense-category budget spending.
- If saving fails, no success message is displayed, my entered values are retained, and I can retry.

## US-08: Create an account

As a new user, I want to create an account so that I can maintain my own private budgeting records.

### Acceptance criteria

- I can access a registration form without being signed in.
- I can enter an email address, password, and password confirmation.
- Required fields and email format are validated.
- Password requirements are displayed before submission.
- A password that does not meet the configured requirements is rejected with a clear explanation.
- Password confirmation must match the entered password.
- Registration does not create multiple accounts for the same email address.
- Successful registration provides a clear next step for signing in or completing any required email verification.
- A new account has no personal transactions or budgets.
- Preset categories are available when the user begins recording expenses.
- Passwords are never displayed back to the user or stored as plain text.