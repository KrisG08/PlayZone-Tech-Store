# 18 — End-to-end verification and regression

**Sprint:** 4 — Documentation, Testing, and Presentation

**What to build:** Proof that the application works: the full workflow checklist executed against the real running application, and a green test suite, with results recorded honestly.

**Blocked by:** 17 — Storefront polish: responsive, states, accessibility.

**Status:** ready-for-agent

- [ ] The end-to-end checklist (register/login, browse, filter, cart, promo accepted/rejected, checkout, stock movement, order history and ownership, reviews, admin flows, authorization refusals) is executed and each item recorded as verified or blocked
- [ ] The complete automated test suite runs, with results recorded in the testing-strategy document
- [ ] Verified defects are fixed and re-tested
- [ ] Order totals, Stock movements and PromoCode usage are spot-checked in the database after a checkout and after a cancellation
- [ ] No requirement is silently skipped; anything unverifiable in this environment is documented as blocked with the reason
