# 17 — Storefront polish: responsive, states, accessibility

**Sprint:** 3 — User Interface

**What to build:** The whole store feels finished: every page usable on phone and desktop, every async surface accounted for, every control doing its job, and user-written content rendered safely.

**Blocked by:** 09 — Customer cancels a New Order; 10 — Verified Purchase Reviews; 12 — Admin: Stock and low-stock; 13 — Admin: Order management and status transitions; 14 — Admin: PromoCode management; 15 — Admin: Revenue and Popularity statistics; 16 — Admin: Review moderation.

**Status:** ready-for-agent

- [ ] All customer and admin pages are responsive, with visible keyboard focus and sufficient contrast
- [ ] Every data-driven view has loading, empty, success and failure states
- [ ] User-generated text (Reviews, names, codes) renders safely with no HTML injection
- [ ] Broken images degrade gracefully without breaking layout
- [ ] Every visible button and link performs its intended action — no placeholder hrefs
- [ ] The API base URL is configurable and errors surface through centralized handling
- [ ] A manual walkthrough of the main Customer and Admin flows is recorded
