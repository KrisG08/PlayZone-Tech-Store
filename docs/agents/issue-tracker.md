# Issue tracker: GitHub

Issues and specs (you may know a spec as a PRD) for this repo live in GitHub Issues at `KrisG08/PlayZone-Tech-Store`.

## Conventions

- One issue per ticket; the spec lives at `.scratch/playzone-tech-store/spec.md` and its ticket breakdown at `.scratch/playzone-tech-store/issues/`
- Tickets are created in dependency order so a ticket's "Blocked by" section can reference real issue numbers
- Triage state is carried by the labels in `triage-labels.md` (`ready-for-agent` by default for published tickets)
- Sprint membership is carried by the `sprint-1`…`sprint-4` labels
- Comments and conversation history go in the issue's comment thread

## When a skill says "publish to the issue tracker"

Use `gh issue create --repo KrisG08/PlayZone-Tech-Store` with the ticket body, the `ready-for-agent` label and the matching sprint label.

## When a skill says "fetch the relevant ticket"

Use `gh issue view <number> --repo KrisG08/PlayZone-Tech-Store`. The user will normally pass the issue number directly.

## Why GitHub

The project is hosted at `github.com/KrisG08/PlayZone-Tech-Store` (private) with `gh` authenticated as `KrisG08`. The local `.scratch/` copies remain the working source for the spec and tickets; GitHub is the published tracker.
