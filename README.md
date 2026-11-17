# DataForSEO

<!-- begin docs -->

Automate SEO and AI visibility workflows with 204 actions and two completion triggers. Version **1.0.0-rc.1** is a release candidate, not a production validation claim.

## Before setting up

Create a DataForSEO account and obtain its API login and API password from API Access. Choose Sandbox while validating workflows. Production requests can incur charges and require sufficient balance and product access.

## Connecting

1. Install the custom app package and find DataForSEO in Apps.
2. Add a connection and enter API login, API password and environment.
3. Connect. No OAuth setup or account selector is needed.

## Actions

- SERPs: live and asynchronous search results, HTML, screenshots and AI summaries.
- Keywords and competitors: volume, trends, difficulty, intent, rankings, intersections and opportunities.
- Backlinks: profiles, referring domains, anchors, history and bulk metrics.
- Site audits: crawling, page/link/content issues, Lighthouse and screenshots.
- Content analysis: discovery, sentiment, distribution and trends.
- AI visibility: mentions, target metrics, trends, AI keyword volume and search scraping.

Actions return typed results, task IDs/status/cost and a complete Blackbird JSON report file. HTML and screenshots also return Content files. Bulk keyword/target inputs accept one-value-per-line text files. Explicit market selections avoid silently choosing a location or language. Complex compound query fields use documented JSON expressions.

## Events

- **On SEO task callback:** manual GET pingback URL, authenticated task verification, possible duplicate deliveries. Use the task ID for downstream idempotency.
- **On SEO task completed:** polling of uncollected tasks, first-read baseline, duplicate suppression and at most 100 Flights per poll. The provider queue is shared and bounded; this is not lossless event history.

## Validation and documentation

Release builds and metadata checks completed. 212 integration tests compile and are discoverable; live tests require credentials. Blackbird installation, UI, runtime mapping and callback delivery remain unverified.

For detailed action and API behavior, consult the source code and the official DataForSEO API documentation. Validate selected workflows in a Blackbird staging environment before production use.

## Feedback

Report issues through your established Blackbird support channel, including the action name, version and redacted provider error/task ID.

<!-- end docs -->
