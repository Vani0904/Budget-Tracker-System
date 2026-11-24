User
 ├── many Transactions
 └── many BudgetLimits

Category
 ├── many Transactions
 └── many BudgetLimits

Only one BudgetLimit per:
UserId + CategoryId + Year + Month


Transaction rules

    1. UserId must identify an owner.

    2. Title must not be empty or whitespace-only.

    3. Surrounding title whitespace is trimmed.

    4. Amount must be greater than zero.

    5. Amount must have no more than two decimal places.

    6. Type must be Income or Expense.

    7. Expense requires a valid category.

    8. Income must not have an expense category.

    9. Transaction date determines its reporting period.

    10. Creation timestamp records when the record was created.
    
    11. GBP-only scope.

Budget limit rules

    1. UserId must identify an owner.

    2. Category must exist.

    3. Month must be between 1 and 12.

    4. Year must be within a supported range that you explicitly choose.

    5. Limit must be greater than zero.

    6. Limit must have no more than two decimal places.

    7. The user/category/year/month combination must be unique.

Ownership rules

    1. A user can only view or change their own transactions.

    2. A user can only view or change their own budget limits.

    3. Ownership must be enforced by the application, not trusted from a user-editable form field.