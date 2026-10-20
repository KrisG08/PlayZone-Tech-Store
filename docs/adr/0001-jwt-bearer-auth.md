# JWT bearer authentication over cookies

The frontend is a separate static HTML/ES-modules app on its own origin, so we chose ASP.NET Core Identity issuing JWT bearer tokens (~60 min expiry, roles in claims, signing secret in user-secrets) over Identity application cookies. Cookies would give real server-side logout and keep tokens out of script reach, but cost antiforgery plumbing in vanilla JS and a clunkier Swagger login flow.

Consequence: logout is client-side token discard only — a stolen token stays valid until expiry. Short expiry is the mitigation; this is a documented known limitation. The token lives in sessionStorage, so it dies with the tab.
