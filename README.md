# Daraja api connector
 
## Table of contents

- [overview](#overview)
- [Requirements](#requirements)
- [Getting_Started](#getting_Started)
- [Known_issues](#known_issues)
- [Authors](#authors)

## overview
The daraja api connector allows low code developers to access safaricom mpesa services and intergrate them to their flows,power app or any othe service in power platform

## requirements
- A Microsoft Azure account. If you don't have one, you can create a [free trial account](https://azure.microsoft.com/en-us/free/)
- An existing Azure Active Directory tenant or the ability to create one.
- microsoft power platform

## getting_Started


### Registering an App in Microsoft Azure
This guide will walk you through the steps to register an app in Microsoft Azure. This is necessary to enable authentication and authorization for your application with Azure Active Directory.

#### Steps to Register an App
- Sign in to the Azure portal using your Azure account credentials.
- In the left-hand menu, click on "Azure Active Directory."
- Click on "App registrations" and then click the "+ New registration" button.
- Enter a name for your app, choose the supported account types, and enter a redirect URI. The redirect URI is the URL where the user will be redirected after successfully authenticating with Azure. If you are not sure what to enter, the redirect url is available as a placeholder on the authentication page when building your connector.
- Click the "Register" button.
- After the app is registered, you will be taken to the app overview page. Here, you can view the app's details and configure various settings.
- To enable authentication, click on "Authentication" in the left-hand menu.
- In the "Implicit grant" section, check the box next to "Access tokens" and "ID tokens" and click the "Save" button.
- Next, click on "Certificates & secrets" in the left-hand menu.
- Click on "+ New client secret" and enter a description for the secret.
- Set the expiration for the secret (e.g. 1 year).
- Click the "Add" button.
- After the secret is generated, copy the value and save it in a secure location. This secret will be used by your application to authenticate with Azure.

## known_issues
known issues will come here

## authors
- bernard karaba  bkaraba14@gmail.com
- john muchiri  jeanfrancaiseharicot@gmail.com
