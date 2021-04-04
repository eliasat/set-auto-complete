# Automatically set Azure DevOps pull requests to auto-complete
One way of making pull request automatically set to auto-complete is to use a service hook in conjunction with an Azure function which calls the DevOps Services REST API. This repository contains an Azure function which is used in this manner.

## How to setup
1. Create the necessary resources in Azure and deploy the function. 
2. Generate a [PAT](https://docs.microsoft.com/en-us/azure/devops/organizations/accounts/use-personal-access-tokens-to-authenticate?view=azure-devops&tabs=preview-page). 
3. Add a new setting "PAT" to the application settings of the function with the value of the generated PAT. 
4. Add a new setting called "AccountId" which value will be the accountId for the user which generated the PAT. (One way of getting the accountId is to go to the project settings in DevOps, Settings/Repositories/<Repository>/ and navigate to the "Security" tab and download detailed report of user permissions.)
5. Create a service hook in the Azure Devops project settings. The service hook should use a web hook and be triggered on the event "Pull request created". Use the function-url (one that contains the azure function key as parameter) in the URL-field.

Now newly created pull requests will automatically be set to auto-complete.

## TODO
Change PAT-authentication to OAuth 2.0 in order to utilize service account instead of personal account.
