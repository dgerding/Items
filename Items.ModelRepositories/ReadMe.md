# DataStores

The DataStores project implements the "business logic" of your app by:

* Managing in memory and persistence related collections of app data
* Providing method-level representations of business logic that query or alter app data

The DataStores provides persistence by implementing the Repository and Unit of Work Pattern.

From the MVVM perspective of the Xamarin.Forms projects, the DataStores Project IS the Model tier of the application.
## ItemsMockDataStore
Provides an in-memory only implementation suitable for testing and as a reference design for persistence-framework specific implementations.

## ItemsSqlLiteDataStore for Device Persistence
Provides a device-side persistence Repository using SQLite and Entity Framework Core.

## ItemsAzureDataStore for Cloud Persistence
Provides "cloud persistece" by implementing an ASP.NET Core Web (REST) interface to MS SQL Server via Entity Framework Core. It can be published directly to Azure or hosted independently.

## DataSync
Provides 

