# 11 — Admin: Product and Category management

**Sprint:** 3 — User Interface

**What to build:** The Admin runs the catalog from a protected dashboard: create, edit and Deactivate Products; create and edit Categories — with validation and confirmation on destructive actions.

**Blocked by:** 03 — Customer account: register, log in, profile; 04 — Catalog: browse, search, filter, sort, and home page.

**Status:** ready-for-agent

- [ ] The dashboard is reachable only by Admins; non-admins are refused server-side even with the direct URL
- [ ] The Admin creates and edits Products (name, Brand, description, price, Stock, image, Category) with server-side validation (price greater than zero, Stock not negative, Category exists)
- [ ] Deactivating a Product removes it from catalog and checkout while historical Orders and Reviews keep it intact (archive semantics per ADR-0003)
- [ ] The Admin creates and edits Categories; deleting a Category that still holds Products is refused with a conflict
- [ ] Destructive actions require confirmation; validation messages appear inline
- [ ] Integration tests cover role refusal, product create/edit, deactivation effect and category-deletion refusal
