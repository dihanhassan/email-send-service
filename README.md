# Email Sending API

This project provides a simple API for sending emails using ASP.NET Core. It includes an endpoint to send emails and handles errors gracefully.

## Features

- **Send Email**: Send an email using a POST request to the `/send-email` endpoint.
- **Error Handling**: Proper error handling with logging and standardized error responses.
- **Asynchronous Processing**: The email sending process is asynchronous to avoid blocking the thread.

## Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) or later.
- An email service provider (e.g., SMTP, SendGrid, etc.) configured in the `_emailService`.

## Getting Started

### Clone the Repository

```bash
[git clone https://github.com/your-username/your-repo-name.git](https://github.com/dihanhassan/email-send-service.git)
cd your-repo-name
