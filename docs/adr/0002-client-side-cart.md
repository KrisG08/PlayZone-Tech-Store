# Client-side cart with server-side quote; no cart tables

The Cart is ephemeral browser-held state, not domain state. We rejected a persistent server-side Cart (two extra entities, login-to-cart, anonymous-cart merge logic) because the Cart never needs to survive a device, and every number it displays is re-derived by the server anyway: a Quote endpoint re-reads prices, Stock and PromoCode rules on demand, and checkout re-validates everything inside a database transaction.

Consequence: an e-commerce store with no Cart table. That is deliberate — the server stays the sole source of truth for prices, discounts and inventory, and a Cart can be built before logging in with nothing to merge.
