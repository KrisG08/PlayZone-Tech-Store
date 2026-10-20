# 03 — Customer account: register, log in, profile

**Sprint:** 2 — Services and Testing

**What to build:** A visitor becomes a Customer and manages their own account: registration with email and password, login, logout, and viewing/editing their profile — with clear inline validation and server error messages on the auth pages.

**Blocked by:** 01 — Foundation: schema, seed data, and ERD.

**Status:** ready-for-agent

- [ ] Registration creates a Customer; the role cannot be escalated by the client; a duplicate email is refused with a conflict
- [ ] Login issues a JWT bearer session (ADR-0001) and rejects bad credentials with a clear client error
- [ ] Passwords exist only as secure hashes and are never returned by any endpoint
- [ ] The Customer reads and updates their own profile; no one can read or write another user's profile
- [ ] Logout discards the token client-side (documented limitation of ADR-0001)
- [ ] Auth endpoints are rate-limited
- [ ] Register/login pages perform client-side validation, surface server errors, and show loading states
- [ ] Integration tests cover register, login, profile read/update, and refusal of unauthorized access
