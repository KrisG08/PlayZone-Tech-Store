# 15 — Admin: Revenue and Popularity statistics

**Sprint:** 3 — User Interface

**What to build:** The Admin dashboard answers "how is the store doing?" with counts, Revenue and best sellers.

**Blocked by:** 12 — Admin: Stock and low-stock; 13 — Admin: Order management and status transitions.

**Status:** ready-for-agent

- [ ] The overview shows total Products, active Products, Customers, total Orders, pending Orders and Revenue
- [ ] Revenue sums TotalAmount only over non-cancelled Orders whose payment is Paid (cash basis per the glossary)
- [ ] Best sellers rank by Popularity (units sold across non-cancelled Orders), ties broken by average Rating then recency
- [ ] The low-stock count is surfaced alongside the report from ticket 12
- [ ] Integration tests cover revenue exclusion rules and best-seller ranking
