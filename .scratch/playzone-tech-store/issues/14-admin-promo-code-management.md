# 14 — Admin: PromoCode management

**Sprint:** 3 — User Interface

**What to build:** The Admin runs campaigns: creates, edits and deactivates PromoCodes with percentage or fixed discounts, validity windows, minimum orders and usage limits.

**Blocked by:** 11 — Admin: Product and Category management; 02 — Domain rules and their unit tests.

**Status:** ready-for-agent

- [ ] The Admin creates and edits PromoCodes: code, description, discount type and value, minimum order amount, optional maximum discount, start/end dates, optional usage limit, active flag
- [ ] Validation enforces percentage greater than 0 and at most 100, positive fixed amounts, and coherent date windows
- [ ] Duplicate codes are refused case-insensitively with a conflict
- [ ] Deleting a PromoCode that has been used is refused; deactivation is always available
- [ ] Integration tests cover the management workflow, validation failures and uniqueness refusal
