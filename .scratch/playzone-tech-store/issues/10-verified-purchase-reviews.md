# 10 — Verified Purchase Reviews

**Sprint:** 2 — Services and Testing

**What to build:** A Customer who actually bought a Product rates it 1–5 and writes a Review, edits or deletes their own Review, and sees the product average update.

**Blocked by:** 05 — Product detail with Reviews; 08 — Customer Order history and detail; 02 — Domain rules and their unit tests.

**Status:** ready-for-agent

- [ ] A Customer with a Verified Purchase can submit one Review per Product with a 1–5 Rating and comment
- [ ] Reviews without a Verified Purchase, duplicates for the same Product, and ratings outside 1–5 are refused with clear errors
- [ ] Owners can edit and delete their own Reviews; other Users' Reviews cannot be touched
- [ ] A Review survives later cancellation of the Order that granted eligibility
- [ ] Product pages show updated average Ratings after any Review change
- [ ] Domain tests cover eligibility and ownership; integration tests cover the submit/edit/delete workflows
