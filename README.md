# Blackbird.io DataForSEO

Blackbird is the new automation backbone for the language technology industry. Blackbird provides enterprise-scale automation and orchestration with a simple no-code/low-code platform. Blackbird enables ambitious organizations to identify, vet and automate as many processes as possible. Not just localization workflows, but any business and IT process. This repository represents an application that is deployable on Blackbird and usable inside the workflow editor.

## Introduction

<!-- begin docs -->

DataForSEO is a provider of SEO and AI visibility data APIs: search engine results, keyword data, backlinks, site audits, content analysis and AI search mentions. Use this app to run SEO research and site audits from Blackbird workflows and pass the results to the next steps.

## Before setting up

Before you can connect you need to make sure that:

- You have a [DataForSEO](https://dataforseo.com/) account with access to the APIs you plan to use.
- You have your API login and API password from the [API Access](https://app.dataforseo.com/api-access) page. The API password is not your account password.
- Your account has enough balance. Most actions are paid per request; see [DataForSEO pricing](https://dataforseo.com/pricing). Use the **Sandbox** environment to build and test workflows without charges; it returns test data.

## Connecting

1. Navigate to **Apps** and search for **DataForSEO**.
2. Click **Add Connection**.
3. Name your connection for future reference, e.g. 'My DataForSEO connection'.
4. Fill in the **API login** and **API password** from the DataForSEO API Access page.
5. Select the **Environment**: **Production** or **Sandbox**.
6. Click **Connect**.
7. Confirm that the connection has appeared and the status is **Connected**.

## Actions

Most DataForSEO APIs offer two modes, and the actions follow them:

- **Live** actions (`Get …` / `Search …`) return results in the same call.
- **Task** actions come in pairs: **Create … task** submits the request and returns its task ID; **Get … results** reads the results of that task once it is ready. Use the **On SEO task completed** event, or the task ID with a delay, to continue the workflow.

Every action returns typed results, task IDs, status, cost and a JSON report file with the full provider response. HTML and screenshot actions also return the content as files. Bulk keyword and target inputs accept a text file with one value per line.

### Account

- **Get account details** returns API usage, prices, spending and other account details.

### SERP

Search engine results for Google (organic, AI Mode, Maps, local finder, news, images, search by image, autocomplete), Bing, YouTube, Yahoo, Baidu, Naver and Seznam, as structured results or raw HTML. Also **Get SERP screenshot** and **Get SERP AI summary** for an existing SERP task.

### Keyword data

Search volume, keywords for site, keyword ideas and keyword performance from Google Ads and Bing, Google Trends and DataForSEO Trends data, and clickstream search volume.

### Keyword and competitor research

DataForSEO Labs data for Google and Amazon: ranked keywords, related keywords and suggestions, keyword difficulty, search intent, domain and SERP competitors, domain and page intersections, traffic estimation and historical rank data.

### Backlinks

Backlink summary and history, backlinks, anchors, referring domains and networks, competitors, domain and page intersections, time series and bulk metrics (ranks, spam score, new and lost backlinks).

### Site audits

- **Create site audit** starts an OnPage crawl of a website; **Stop site audit** stops it.
- **Get audit summary** and the other **Get audit …** / **Search audit …** actions read pages, links, resources, duplicate tags and content, redirect chains, non-indexable pages, microdata, keyword density and raw HTML of a finished crawl.
- **Get page screenshot**, content parsing, instant pages and Lighthouse actions analyze single pages.

### Content analysis

Content search, summary, sentiment analysis, rating distribution, phrase trends and category trends for brand and topic mentions on the web.

### AI visibility

- ChatGPT and Gemini AI search results, as a task or live, structured or HTML.
- AI keyword search volume.
- AI mentions of a brand or domain: mentions, target metrics, top domains, pages and brands, historical data and time series.

## Events

- **On SEO task completed** polls DataForSEO for completed tasks of the selected task family and starts one Flight per new task. The first poll only records the tasks that are already completed. The provider queue holds uncollected tasks only, so other tools that collect tasks from the same account can cause missed events.
- **On SEO task callback** starts a Flight when DataForSEO calls the pingback URL of a task. In the **Pingback URL** input of a **Create … task** action, enter the event's webhook URL followed by `?id=$id`; DataForSEO replaces `$id` with the task ID. The app verifies the task with your account before starting the Flight. DataForSEO can deliver the same callback more than once, so use the task ID to avoid duplicate processing.

## Limitations

- DataForSEO charges for most requests, including requests that fail later in the workflow. Check task history in your DataForSEO account before repeating a failed paid action.
- Some inputs that take compound queries (filters, order rules) expect JSON in the format described in the [DataForSEO API documentation](https://docs.dataforseo.com/v3/).

## Feedback

Do you want to use this app or do you have feedback on our implementation? Reach out to us using the [established channels](https://www.blackbird.io/) or create an issue.

<!-- end docs -->
