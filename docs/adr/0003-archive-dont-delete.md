# Archive, don't delete

Products are never hard-deleted — only deactivated — because OrderItems and Reviews reference them and historical orders must stay meaningful after a Product is renamed or retired. Categories are hard-deletable only when no Products reference them (otherwise the API refuses with a conflict). PromoCodes are deactivated; hard deletion is allowed only for codes that were never used.

Consequence: the DELETE semantics of the admin API differ per entity and the catalog accumulates deactivated Products. That is the price of an append-only order history; there is no cascade delete anywhere near Orders, Users or Products.
