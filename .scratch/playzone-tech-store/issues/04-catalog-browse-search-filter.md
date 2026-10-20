# 04 — Catalog: browse, search, filter, sort, and home page

**Sprint:** 2 — Services and Testing

**What to build:** Anyone can explore the store: a home page with hero, categories, featured Products and best sellers, and a catalog page with search, filters, sorting and pagination — all over live API data.

**Blocked by:** 01 — Foundation: schema, seed data, and ERD; 02 — Domain rules and their unit tests.

**Status:** ready-for-agent

- [ ] The catalog lists active Products with name, Brand, price, availability and average Rating fetched from the API — no hardcoded product data
- [ ] Search matches name and Brand; filters cover Category, Brand, price range and stock availability; sorting covers name, price and Popularity (units sold per the glossary)
- [ ] Pagination works in both directions and reports total counts
- [ ] Deactivated Products never appear in listings
- [ ] The home page renders featured Products, Categories and best sellers from API data, with a useful empty state
- [ ] Loading, empty and error states are visible on every async surface
- [ ] Integration tests cover listing, search, filtering, sorting and pagination
