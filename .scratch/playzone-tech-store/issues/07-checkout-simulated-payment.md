# 07 — Checkout and Simulated Payment

**Sprint:** 2 — Services and Testing

**What to build:** A logged-in Customer turns their Cart into an Order: shipping details, payment method, a clearly labelled Simulated Payment, and an Order confirmation with OrderNumber and totals.

**Blocked by:** 03 — Customer account: register, log in, profile; 06 — Cart and server-side Quote; 02 — Domain rules and their unit tests.

**Status:** ready-for-agent

- [ ] Checkout collects address, city, postal code, country and payment method (Card, PayPal, Cash on Delivery) with validation
- [ ] The Order is created atomically: OrderItems hold purchase-time UnitPrice and LineTotal, totals are server-computed, and the OrderNumber is unique and human-readable
- [ ] Stock is decremented in the same transaction; a purchase above Stock is refused with no partial changes
- [ ] PromoCode usage is incremented exactly once on success
- [ ] Card and PayPal are marked Paid by the simulated gateway; Cash on Delivery is Pending until Delivered; no card number or CVV field exists anywhere in the system
- [ ] The UI clearly states that payment is simulated and never claims real processing occurred
- [ ] The confirmation page shows OrderNumber, items and all totals
- [ ] Integration tests cover successful checkout, oversell rejection, invalid PromoCode rejection and totals correctness
