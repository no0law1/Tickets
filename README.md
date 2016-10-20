# Tickets
App created for an advanced database course in ISEL.

## Development of a ticket system to a client support store

### Entity-Relationship Model
![Entity Relationship Model](https://cloud.githubusercontent.com/assets/6998549/19579484/d4643964-9718-11e6-9fac-eeee4bd31875.png)

First Phase consisted in using views, triggers, functions, isolation levels and transaction control in SQL Server.

Second Phase consisted in creating an app using what was created in the First Phase.

We used .NET to make possible all the functionalities asked, which was:
* Show unclosed tickets existing in the system and their details.
* Assign a ticket to a techician.
* Insert an action associated to a ticket, making it possible to change it's state.
* Remove a ticket.
* Export a ticket's information in XML Schema.

This application was implemented twice as requested.
One using .NET's Entity Framework and the other by not using .NET's Entity Framework.


