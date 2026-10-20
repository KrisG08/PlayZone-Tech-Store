# PlayZone Tech Store

An online store for gaming peripherals, with Customers who shop and Admins who run the store.

## Language

**User**:
A person with an account who can authenticate. Every User holds one or both store roles.
_Avoid_: account, member

**Customer**:
A User acting as a buyer — the owner of Orders and Reviews.
_Avoid_: client, buyer, shopper

**Admin**:
A User who manages the store. An Admin may also shop as a Customer.

**Product**:
A single purchasable item in the catalog, belonging to one Category.
_Avoid_: item, article, SKU

**Category**:
A named grouping of Products (e.g. Keyboards, Mice, Headsets).

**Brand**:
The manufacturer name shown on and searchable across Products.

**Stock**:
The number of units of a Product on hand and available for sale. Never negative.
_Avoid_: inventory count, quantity on hand

**Order**:
A committed purchase made by a Customer, containing one or more OrderItems. Immutable once placed except through status changes.
_Avoid_: purchase, transaction

**OrderItem**:
One line of an Order, holding the purchase-time UnitPrice and the ordered quantity.
_Avoid_: line, entry

**OrderNumber**:
The unique human-readable identifier of an Order, shown to the Customer.

**Order status**:
The fulfilment state of an Order: New, Processing, Shipped, Delivered, or Cancelled. Shipped, Delivered, and Cancelled are final.

**Payment status**:
The money state of an Order: Pending, Paid, Failed, or Refunded.

**Simulated Payment**:
The stand-in payment workflow used in place of a real payment provider. No card numbers or CVVs are ever collected; no real money moves.
_Avoid_: fake payment, mock checkout

**Cart**:
An ephemeral, browser-held selection of Products a Customer intends to buy. Not persisted; it becomes an Order at checkout.
_Avoid_: basket, bag

**Checkout**:
The act of turning a Cart into an Order: shipping details, payment method, server-side validation and totals, atomic commit.

**Quote**:
A non-binding server price preview for a proposed set of OrderItems. Only the Order itself is authoritative.

**Subtotal**:
The sum of the OrderItems' rounded line totals, before discount and shipping.

**DiscountAmount**:
The money subtracted from a Subtotal by a PromoCode.

**ShippingCost**:
The delivery charge added to an Order: a flat fee, waived when the discounted subtotal reaches the free-shipping threshold.

**TotalAmount**:
What the Customer pays: Subtotal minus DiscountAmount plus ShippingCost.

**PromoCode**:
A named discount rule with a validity window and usage limits, applied at checkout.
_Avoid_: coupon, voucher

**Verified Purchase**:
A non-cancelled Order by that User containing that Product — the requirement for submitting a Review.

**Review**:
A Customer's written assessment of a Product, carrying a Rating. At most one per User per Product.

**Rating**:
The 1–5 score inside a Review.

**Deactivate**:
Remove from sale without deleting. Deactivated Products vanish from the catalog and checkout but remain on historical Orders and Reviews.
_Avoid_: delete, remove

**Revenue**:
Money collected: the sum of TotalAmount over Orders that are not Cancelled and whose payment is Paid.
_Avoid_: sales, turnover

**Popularity**:
Units sold across non-cancelled Orders; the basis for best-seller ranking and catalog sort-by-popularity.
_Avoid_: trending, hotness

**Low stock**:
A Product whose Stock has reached the configured reorder threshold.
