# login-sys-demo
A login System demo that also has the ability to recover user password along with recovery code expiration feature in c# ( C-Sharp )
# Description
This is just a demo login system in which users can login to their accounts and also if the user forgets (his / her ) password then ( he / she) can recover it. The Password Recovery procedure involves finding the user email if it is found the a random code will be sent to the user , and then the user has to input that code if the code is right then the user will be redirected to password reset form. The code also has expiration means after some time the code which was sent to the user will be expired!

# Dependencies
1) Visual Studio
2) Dot Net framework
3) Microsoft Sql Server Management System
4) Needs internet for sending email

# Things to setup before running program
Please enter your email address and password in *CLASS EMAIL* (you can get this : LoginSystem/BackEnd/Email.cs), also enable less secure app option (description link regarding less secure app is also given in class email) . I've used 50 seconds for code expiration set this up according to your requirement. This can be found in *CLASS PASSWORDRECOVERY* (you can get this : LoginSystem/Forms/PasswordRecovery.cs). Please Execute demo quries in SSMS (you can get this : Database-Demo-Query/SQL-DEMO-QUERY.sql). Please don't forget to add server name in EstablishConnection method of Class Database (you can get this : LoginSystem/BackEnd/Database.cs)
