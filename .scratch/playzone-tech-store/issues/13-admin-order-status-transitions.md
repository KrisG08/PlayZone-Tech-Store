# 13 — Admin: Order management and status transitions

**Sprint:** 3 — User Interface

**What to build:** The Admin fulfils Orders: sees every Order, advances it along the permitted status path, and cancels exceptions with correct rollbacks.

**Blocked by:** 08 — Customer Order history and detail; 11 — Admin: Product and Category management; 02 — Domain rules and their unit tests.

**Status:** ready-for-agent

- [ ] The Admin lists and opens every Order with Customer, items, totals and statuses
- [ ] Status advances only along New → Processing → Shipped → Delivered; illegal moves (e.g. Delivered → Processing) are refused
- [ ] The Admin cancels a New or Processing Order; Stock and PromoCode usage are restored exactly once and Paid becomes Refunded
- [ ] Customers cannot change Order status through any endpoint
- [ ] Integration tests cover listing, valid transitions, illegal-move refusal and admin cancellation effects
