// See https://aka.ms/new-console-template for more information

//SRP(S), single responsability
//A class should have one and only reason to change
//A class should have only one job

using SOLID_Principes;

StandarMessages.welcomeMessage();

Person user = PersonDataCapture.capture();

bool isUserValid = PersonValidator.validate(user);

if(!isUserValid)
{
    StandarMessages.endApplication();
    return;
}

//Create a username for the person
AccountGenerator.CreateAccount(user);

StandarMessages.endApplication();

