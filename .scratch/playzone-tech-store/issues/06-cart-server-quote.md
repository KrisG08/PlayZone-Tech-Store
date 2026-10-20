# 06 — Cart and server-side Quote

**Sprint:** 2 — Services and Testing

**What to build:** The Customer assembles a Cart and sees trustworthy money: line totals, Subtotal, DiscountAmount, ShippingCost and TotalAmount computed by the server, with PromoCode application or plain-language refusal.

**Blocked by:** 05 — Product detail with Reviews; 02 — Domain rules and their unit tests.

**Status:** ready-for-agent

- [ ] The Cart supports add, quantity change, remove and clear in the browser; per ADR-0002 it is client-side and not persisted server-side
- [ ] A server Quote endpoint computes all totals from current prices, Stock and PromoCode rules; client-supplied money values are ignored
- [ ] A PromoCode applies its percentage or fixed discount with cap and minimum-order enforcement, or is refused with a reason (unknown, expired, not started, usage limit reached, minimum not met)
- [ ] Shipping is the flat configured fee, waived when the discounted Subtotal reaches the threshold
- [ ] The cart page shows server totals and refreshes them when quantities or codes change
- [ ] Quote computation and promo refusal are covered by integration tests; discount and shipping arithmetic reuses the tested rules from ticket 02
