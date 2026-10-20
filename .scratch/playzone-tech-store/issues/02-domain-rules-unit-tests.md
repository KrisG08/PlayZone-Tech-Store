# 02 — Domain rules and their unit tests

**Sprint:** 1 — Data and Business Logic

**What to build:** The store's business rules as pure, testable logic with unit tests — the arithmetic and policy brain that checkout, promotion, inventory, status and review flows will call. Verifiable on its own: the test suite demonstrates every rule and its failure cases.

**Blocked by:** 01 — Foundation: schema, seed data, and ERD.

**Status:** ready-for-agent

- [ ] Money rounding is pinned at the three boundaries (OrderItem line total, DiscountAmount, TotalAmount) and tested at rounding edges
- [ ] Percentage and fixed-amount discounts compute correctly, honour maximum-discount caps and minimum-order amounts, and never produce a negative total
- [ ] Shipping is a flat configurable fee waived when the discounted Subtotal reaches the configured threshold, tested on both sides of the boundary
- [ ] Stock validation rejects zero/negative quantities and quantities above Stock, and forbids negative Stock
- [ ] The order-status transition table is enforced: New → Processing → Shipped → Delivered, Cancelled reachable from New (anyone) or Processing (Admin only), Shipped/Delivered/Cancelled final; illegal moves rejected
- [ ] Review rules enforce rating 1–5, one Review per User per Product, ownership for edit/delete, and Verified Purchase eligibility (a non-cancelled Order containing that Product)
- [ ] Revenue counting includes only non-cancelled Orders whose payment is Paid
- [ ] Every rule has passing unit tests covering success and failure cases
