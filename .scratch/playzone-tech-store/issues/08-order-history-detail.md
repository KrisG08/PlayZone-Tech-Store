# 08 — Customer Order history and detail

**Sprint:** 2 — Services and Testing

**What to build:** The Customer sees their purchases: an order history list and per-Order detail with historical prices, so later price changes never rewrite a receipt.

**Blocked by:** 07 — Checkout and Simulated Payment.

**Status:** ready-for-agent

- [ ] Order history lists the Customer's Orders with OrderNumber, date, status, payment status and TotalAmount
- [ ] Order detail shows each OrderItem with purchase-time UnitPrice and LineTotal, plus Subtotal, DiscountAmount, ShippingCost and TotalAmount
- [ ] Status and payment status are displayed using the domain vocabulary
- [ ] Accessing another Customer's Order is refused with not-found or forbidden
- [ ] Integration tests cover history listing, detail retrieval and ownership refusal
