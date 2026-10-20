# 01 — Foundation: schema, seed data, and ERD

**Sprint:** 1 — Data and Business Logic

**What to build:** The data backbone the whole store stands on: the eight core entities (Role, User, Category, Product, Order, OrderItem, Review, PromoCode) mapped to a SQL Server database with constraints, indexes and safe delete behaviours; an EF Core migration that creates the schema; a repeatable development seed; and a database-design document whose Mermaid ERD matches reality. No store UI in this slice — it proves the data layer and the developer experience.

**Blocked by:** None — can start immediately.

**Status:** ready-for-agent

- [ ] The solution builds with zero errors on the installed .NET SDK
- [ ] All eight core entities exist with primary keys, foreign keys, constraints, indexes and explicit delete behaviours; no delete cascades onto Users, Products or Orders
- [ ] An EF Core migration creates the schema on SQL Server LocalDB and can be applied to an empty database
- [ ] The development seed initialises twice without duplicates: Categories, at least fifteen Products across brands and price bands including low-stock cases, several PromoCodes with different rules, sample Reviews, and a development Admin clearly marked as development-only
- [ ] Money values use decimal with documented two-place rounding; stored timestamps are UTC
- [ ] The database-design document contains a Mermaid ERD whose entities, keys, cardinalities and optionality match the migration
- [ ] Unknown routes and unhandled errors return consistent, leak-free error bodies (no stack traces or connection strings)
