# 09 — Customer cancels a New Order

**Sprint:** 2 — Services and Testing

**What to build:** A Customer who changes their mind cancels their own Order while it is New, and the store rolls back exactly what it took.

**Blocked by:** 08 — Customer Order history and detail; 02 — Domain rules and their unit tests.

**Status:** ready-for-agent

- [ ] A cancel action with confirmation is available on the Customer's own Order while its status is New
- [ ] Cancellation restores Stock and decrements PromoCode usage exactly once; a Paid Order becomes Refunded
- [ ] A second cancellation attempt is refused; cancelling Shipped, Delivered or Cancelled Orders is refused
- [ ] Cancelling another Customer's Order is refused
- [ ] Domain tests cover the transition table; integration tests cover exactly-once restoration and the refusal cases
