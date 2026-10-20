# Spec: PlayZone Tech Store

Status: ready-for-agent

## Problem Statement

A Customer who wants gaming peripherals — keyboards, mice, headsets — has no trustworthy place to shop for them online. They cannot browse a catalog, compare prices and stock, read what other buyers think, apply a discount they were given, or place an order and follow it to delivery. The store's Admin has no better situation: without an order book, a stock ledger, and promotion controls, running the shop means spreadsheets and guesswork. Money calculations made in the browser cannot be trusted, and stock cannot be promised reliably.

## Solution

PlayZone Tech Store is a complete e-commerce web application with a dark gaming-storefront frontend and an ASP.NET Core Web API backend over a SQL Server database. A Customer registers, browses a searchable and filterable catalog, fills an ephemeral Cart, checks out through a clearly labelled Simulated Payment, and follows the resulting Order through its status lifecycle — leaving Reviews backed by Verified Purchases. An Admin manages Products, Categories, Stock, PromoCodes and Order statuses, and watches Revenue and Popularity from a protected dashboard. Every business rule — prices, discounts, Stock, eligibility, authorization — is enforced on the server; the browser is presentation only.

## User Stories

1. As a visitor, I want to register with my name, email and a password, so that I can become a Customer and shop.
2. As a visitor, I want the registration form to reject weak passwords and malformed emails inline, so that I fix mistakes before submitting.
3. As a Customer, I want to log in with email and password, so that my Cart, Orders and Reviews are mine alone.
4. As a Customer, I want to be told clearly when my login fails, so that I know whether to retype or reset.
5. As a Customer, I want to log out, so that my session on a shared computer is finished.
6. As a Customer, I want to view my profile, so that I can check what the store knows about me.
7. As a Customer, I want to update my name and email, so that my details stay current.
8. As a Customer, I want my password to be stored only as a secure hash, so that a leaked database cannot expose it.
9. As a Customer, I want to browse the product catalog, so that I can see what the store sells.
10. As a Customer, I want to search products by name and brand, so that I can find a specific device quickly.
11. As a Customer, I want to filter by category, brand, price range and stock availability, so that I narrow the catalog to what I can actually buy.
12. As a Customer, I want to sort by name, price and popularity, so that results arrive in the order I care about.
13. As a Customer, I want paginated product lists, so that large catalogs stay fast and navigable.
14. As a Customer, I want each product card to show image, name, brand, price, availability and average rating, so that I can compare without clicking through.
15. As a Customer, I want a product detail page with full description and reviews, so that I can decide before buying.
16. As a Customer, I want out-of-stock products marked honestly, so that I do not plan around gear I cannot have.
17. As a Customer, I want deactivated products to disappear from the catalog, so that I never see items I cannot buy.
18. As a Customer, I want to add a product in a chosen quantity to my Cart, so that I can buy several things at once.
19. As a Customer, I want to change quantities and remove items in my Cart, so that I can adjust my selection before paying.
20. As a Customer, I want the Cart to show line totals, Subtotal, DiscountAmount, ShippingCost and TotalAmount, so that I know exactly what I will pay.
21. As a Customer, I want those totals computed by the server, so that the numbers on screen match the Order I will be charged for.
22. As a Customer, I want to apply a PromoCode in the Cart, so that I get the discount I was promised.
23. As a Customer, I want an invalid PromoCode refused with a plain-language reason, so that I understand why it did not apply.
24. As a Customer, I want free shipping once my discounted Subtotal reaches the threshold, so that larger orders are rewarded.
25. As a Customer, I want to enter shipping address, city, postal code and country at checkout, so that my Order can be delivered.
26. As a Customer, I want to choose a payment method — Card, PayPal or Cash on Delivery, so that I can pay the way I prefer.
27. As a Customer, I want to see clearly that payment is simulated and that no card details are ever requested, so that I am never misled or put at risk.
28. As a Customer, I want checkout to reject quantities above Stock, so that I never pay for something the store cannot ship.
29. As a Customer, I want checkout to re-check prices and Stock on the server at the moment of purchase, so that a stale Cart cannot be exploited.
30. As a Customer, I want my Order to be created atomically, so that a failure never leaves a half-placed Order or wrong Stock.
31. As a Customer, I want an Order confirmation showing OrderNumber and totals, so that I have proof of the purchase.
32. As a Customer, I want to see my order history, so that I can find past purchases.
33. As a Customer, I want order details showing the purchase-time prices of each OrderItem, so that later price changes never rewrite my receipt.
34. As a Customer, I want to see my Order's status and payment status, so that I know where my delivery stands.
35. As a Customer, I want to cancel my Order while it is still New, so that a mistake can be undone before it is handled.
36. As a Customer, I want cancellation to restore Stock and the PromoCode usage exactly once, so that other buyers are not penalised by my abandoned Order.
37. As a Customer, I want a cancelled Order to show as Refunded when it had been Paid, so that the money story stays consistent.
38. As a Customer, I want attempts to open another Customer's Order refused, so that my purchases stay private.
39. As a Customer, I want to submit a Review with a 1–5 Rating for a product I bought, so that I can share my experience.
40. As a Customer, I want to be blocked from reviewing a product I never bought, so that Reviews reflect real use.
41. As a Customer, I want to be blocked from a second Review of the same product, so that ratings cannot be stuffed.
42. As a Customer, I want to edit or delete my own Review, so that I can correct or withdraw what I wrote.
43. As a Customer, I want my Review to survive even if that Order is later cancelled, so that my opinion is not retroactively erased.
44. As a Customer, I want product pages to show all Reviews and the average Rating, so that I can judge quality before buying.
45. As a Customer, I want every page to work on my phone, so that I can shop from anywhere.
46. As a Customer, I want loading, empty and error states everywhere data is fetched, so that I am never left staring at a blank screen.
47. As a Customer, I want broken product images to fall back gracefully, so that one missing picture never wrecks the layout.
48. As an Admin, I want a dashboard that only I can reach, so that store management is not exposed to Customers.
49. As an Admin, I want to see totals for products, active products, customers, orders and pending orders, so that I grasp the store's state at a glance.
50. As an Admin, I want to see Revenue and how it is counted, so that I know what the number means.
51. As an Admin, I want a best-selling products list ranked by Popularity, so that I know what to restock and promote.
52. As an Admin, I want a low-stock report, so that I can reorder before items run out.
53. As an Admin, I want to create a Product with name, brand, description, price, Stock, image and Category, so that the catalog grows.
54. As an Admin, I want to edit any Product field, so that the catalog stays accurate.
55. As an Admin, I want to deactivate a Product rather than delete it, so that historical Orders and Reviews keep their meaning.
56. As an Admin, I want price and Stock validation on every write, so that the catalog can never hold a negative Stock or a zero-price Product.
57. As an Admin, I want to create, rename and describe Categories, so that browsing stays organised.
58. As an Admin, I want Category deletion refused while Products still belong to it, so that no Product is orphaned.
59. As an Admin, I want to adjust Stock quantities directly, so that I can record deliveries and corrections.
60. As an Admin, I want to see all Customer Orders, so that I can run fulfilment.
61. As an Admin, I want to move an Order along its status path — New to Processing to Shipped to Delivered, so that progress is recorded.
62. As an Admin, I want impossible status moves refused, so that a Delivered Order can never silently return to Processing.
63. As an Admin, I want to cancel a New or Processing Order, so that exceptions can be resolved.
64. As an Admin, I want cancellation to restore Stock and PromoCode usage exactly once and mark Paid orders Refunded, so that books stay balanced.
65. As an Admin, I want to create PromoCodes with percentage or fixed discounts, validity windows, minimum order amounts and usage limits, so that campaigns can run.
66. As an Admin, I want to edit or deactivate a PromoCode, so that campaigns can be adjusted or stopped.
67. As an Admin, I want PromoCode uniqueness enforced case-insensitively, so that no two codes collide.
68. As an Admin, I want to delete an abusive Review, so that the store's pages stay civil.
69. As an Admin, I want my own purchases and Reviews to follow the same rules as any Customer, so that the model has no special cases.
70. As the store, I want every money value stored and computed in EUR with consistent rounding, so that totals never drift by a cent.
71. As the store, I want Order numbers to be unique and human-readable, so that support conversations can reference them.
72. As the store, I want Stock to never go negative, even under simultaneous checkouts, so that the store never oversells.
73. As the store, I want unauthorized admin API calls refused server-side, so that a hidden button is never mistaken for security.
74. As the store, I want consistent, leak-free error responses, so that stack traces and secrets never reach a browser.

## Implementation Decisions

- **Solution shape.** A layered ASP.NET Core Web API solution on the current LTS SDK, with distinct projects for domain entities and rules, application services and DTOs, infrastructure (EF Core, Identity, migrations, seed), the API host, a static HTML/CSS/ES-modules frontend, and two test projects. Dependencies point inward: business rules never reference HTTP or the frontend.
- **Identity.** A single User entity built on ASP.NET Core Identity; Customer and Admin are roles on that entity, not separate tables. Registration always assigns Customer; the development seed creates a clearly-marked Admin account. No custom role foreign key — Identity's role mechanism is reused rather than duplicated. Email is unique. Passwords exist only as Identity hashes.
- **Glossary.** The shared vocabulary in CONTEXT.md governs naming across code and docs; the three recorded ADRs (JWT bearer auth, client-side Cart with server Quote, archive-don't-delete) are binding for this work.
- **Cart.** Client-side and ephemeral; it is not persisted and no cart tables exist. A Quote endpoint re-reads Product prices, Stock and PromoCode rules to produce Subtotal, DiscountAmount, ShippingCost and TotalAmount. Checkout re-validates everything server-side inside a database transaction; nothing the browser sends about money is trusted.
- **Money.** EUR only, two-decimal money, rounded away from zero at exactly three boundaries: the OrderItem line total, the DiscountAmount, and the TotalAmount. Subtotal is the sum of rounded line totals.
- **Shipping.** A flat ShippingCost to any country, waived when the discounted Subtotal reaches a configured free-shipping threshold. Both values live in configuration, not in code.
- **PromoCode rules.** Codes are unique case-insensitively; discount is percentage (greater than 0 and at most 100) or fixed (positive); optional minimum order amount and maximum discount cap; a validity window; an optional global usage limit with a usage counter. Discounts never produce a negative total. Cancellation decrements the usage counter exactly once. There is no per-Customer usage cap in this version.
- **Order lifecycle.** Status moves New → Processing → Shipped → Delivered, with Cancelled reachable from New by anyone and from Processing by an Admin only. Shipped, Delivered and Cancelled are final. Cancellation restores Stock exactly once, decrements PromoCode usage exactly once, and flips Paid to Refunded. Customers can never set statuses themselves.
- **Payment.** Simulated Payment only: methods Card, PayPal and Cash on Delivery. Card and PayPal run through a mock gateway that always succeeds and marks the Order Paid at checkout; Cash on Delivery starts Pending and becomes Paid when the Order is Delivered. No card number or CVV field exists anywhere in the system. Failed is reserved for a future real provider. The UI must label the workflow as simulated.
- **Reviews.** Submission requires a Verified Purchase: a non-cancelled Order by that User containing that Product. At most one Review per User per Product, rating 1–5. Eligibility is checked at submission only — a later cancellation does not remove the Review. Owners edit or delete their own; an Admin may hard-delete any Review; there is no hidden state.
- **Deletion policy.** Products are deactivated, never deleted. Categories are deleted only when no Products reference them, otherwise refused with a conflict. PromoCodes are deactivated; hard deletion only when never used. No cascade delete touches Users, Products or Orders; OrderItems keep their purchase-time prices forever.
- **Revenue and Popularity.** Revenue is the sum of TotalAmount over Orders that are not Cancelled and whose payment is Paid. Popularity is units sold across non-cancelled Orders, with average rating then recency as tie-breakers; it drives best sellers and catalog sort-by-popularity.
- **Inventory.** Stock is decremented only when an Order commits, inside the same transaction, with concurrency protection so two checkouts cannot both take the last unit. Purchases exceeding Stock are rejected. A reorder threshold for the low-stock report lives in configuration.
- **Order numbers.** Generated server-side in a compact unique human-readable format with a uniqueness constraint.
- **API surface.** REST under a versioned prefix: auth register/login/logout, current-user profile read and write; product listing with search, category, brand, price-range, availability, sorting and pagination; product detail and its reviews; category listing; quote; orders create/list/detail; product reviews create/update/delete; promo-code validation; and an admin area covering products, categories, orders and status changes, promo codes, low-stock, statistics overview and top products. Admin areas are authorized server-side by role; customer resources are ownership-checked.
- **Validation and errors.** DTO-level validation with data annotations plus pure domain rule checks for money, Stock, statuses and eligibility. Missing records return not-found; duplicate email and duplicate promo code return conflict; rule violations return client errors with consistent bodies; unexpected failures return a sanitized server error. Structured logging throughout. Auth endpoints are rate-limited.
- **Seed data.** Idempotent development seeding: the Categories, at least fifteen realistic Products across brands and price bands including low-stock cases, sample Reviews, several PromoCodes with different rules, and the development Admin. Local placeholder product images with a broken-image fallback; nothing loads from external image hosts at runtime.
- **Frontend.** Static HTML/CSS/ES modules with a dark gaming aesthetic: home, catalog, product detail, cart, checkout, auth pages, account with order history and detail, and the admin dashboard. A shared API module with configurable base URL, centralized error handling, semantic markup, safe rendering of user-written text, and loading/empty/error states on every async surface. Every visible control performs its action.

## Testing Decisions

A good test asserts externally visible behaviour — what a caller sends and what the system answers or stores — never which internal methods ran or how objects are shaped inside. Tests must be deterministic: no clock dependence, no external services, no order dependence.

Testing runs at two seams, as few as the subject allows:

- **The API seam (primary, highest).** Integration tests drive the real HTTP surface of the application host against a real SQL Server database created per test run — schema created, seeded, exercised, dropped. This is where workflows are proven: registration and login, catalog retrieval and filtering, successful Order creation with correct totals and Stock movement, rejection of insufficient Stock, rejection of an invalid PromoCode, refusal to read another Customer's Order, refusal of admin endpoints to non-admins, admin status transitions, and Review submission and retrieval. Authorization and transactional consistency are only meaningful here.
- **The domain-rule seam (pure, no I/O).** Money and rules with sharp edges — percentage and fixed discounts, maximum-discount caps, minimum-order checks, shipping and free-shipping boundaries, rounding boundaries, Stock validation, status transition tables, Review eligibility and ownership, revenue counting — are tested as pure units against their rule modules. These have no database and no HTTP; they are fast and exhaustive where the API seam would be slow and coarse.

Prior art: this is a greenfield repository — there are no existing tests to match. The two test projects establish the house pattern: workflow scenarios at the API seam, arithmetic and rule tables at the domain seam.

Mocking is used only where a real collaborator would drag in nondeterminism; the database in integration tests is deliberately real. Tests are run with the standard .NET test runner and their actual pass/fail results recorded in the testing-strategy document — never assumed.

## Out of Scope

- Real payment providers, real card capture, and any card number or CVV field in the system.
- A persistent server-side Cart, cart merge on login, and cart sharing across devices.
- Per-Customer PromoCode usage limits, multi-code stacking, and automatic campaign scheduling.
- Wishlist, product variants, multi-currency pricing, tax calculation, and partial shipments or partial refunds.
- Email delivery (order confirmations, password reset messages) — the flows exist only where the prompt requires them; no mail transport is configured.
- Guest checkout: every Order belongs to a registered User.
- Returns and refund workflows beyond cancelling an Order before it ships.
- Review moderation beyond hard deletion — no hidden, flagged or pending states.
- Product image upload pipeline — development uses local placeholder assets.
- Production deployment, CI/CD pipelines, load testing and multi-tenant concerns.
- Full-text search engine features: search is simple matching on name and brand.

## Further Notes

- **Seam choice.** Two seams rather than one: the API seam is the highest seam and carries the workflows, but money rounding boundaries and transition tables are illegible through HTTP alone. The domain seam exists only for those pure rules; nothing else gets its own seam.
- **Environment constraints.** A full SQL Server instance is not available in this environment; SQL Server LocalDB backs both development and integration tests, with the EF Core migrations targeting SQL Server throughout. Anything not verifiable here is recorded honestly in the sprint tracker rather than claimed as done.
- **Auth limitation.** With JWT bearer, logout discards the token client-side only; a captured token stays valid until expiry. Short expiry is the mitigation and the limitation is documented.
- **Sprint structure.** Development is organized in the four mandated sprints — Data and Business Logic, Services and Testing, User Interface, Documentation and Presentation — with a live sprint tracker. The minimal API surface needed by integration tests lands with the services sprint; the remaining endpoints land with the interface sprint.
- **Trust boundary.** The browser is never a source of truth for prices, discounts, Stock, payment status or identity. Everything money-shaped is recomputed on the server before anything is committed.
