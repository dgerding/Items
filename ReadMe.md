[IN PROGRESS - DRAFT :) ]

“Items” 
The New Take on the Cross-Platform Solution Template
or
How to reach 4.1 billion active device users and be home for dinner.
By David Gerding
 [Author’s note: A couple years back Microsoft’s Azure Mobile QuickStart promised an amazing mix of features for cross-platform development, including device and cloud persistence with sync, authentication and 3rd-party authentication, even device notifications!  All in a single solution delivering compatible apps with native UX to iOS, Android and Windows.  
In all the commotion of Xamarin joining Microsoft and the concurrent move to truly cross-platform .net via .net Standard and .net Core, the Azure Mobile SDK stopped working very reliably.  So, the following is an attempt to help others, including Microsoft, get and deliver on all the awesome promise that was the “Azure Mobile Client and Mobile SDK” combined with Xamarin.  But with an approach that’s less likely to stumble, more open, easier to teach as a starting point and that appeals to the broadest possible mix of app developers.]
What Is It?
The “Items” Visual Studio solution (Mac or Windows) template uses opensource, cross-platform .net frameworks (.net Core/.Net Standard/Xamarin) to deliver a functionally identical but native app experience (using native UX runtime not embedded html) on iOS, Android, and Windows devices. And soon MacOS and Linux desktops, too.
It can be used by newcomers and experienced developers alike to grow from zero to enterprise or app store quality – across multiple platforms - without significant refactoring along the way.  
It lets users:
•	List
•	Create
•	Edit
•	Delete
•	and View the details 
of “Items”, demonstrating real-world, cross-platform, data-oriented UX and bound-data CRUD against both local and cloud-based persistence without any vendor locked runtimes. And it even demonstrates secure, platform-specific device storage of basic app runtime settings. Another very common need.
Out of the box it compiles to and runs on:
•	 iOS
•	 Android
•	 Windows Desktop (UWP)
And in the very near term (May 18?) should also compile and run to: 
•	 MacOS
•	 Windows Desktop (WPF)
•	 Linux (GTK#)
•	 Xbox One (UWP)
•	 Samsung TVs (Tizen)
It’s an extensible, no-vendor-locked, 100% cross-platform wonderland that as far I know only contemporary .net can deliver.  
4+ Billion Active User Devices!! The Most Supported Devices Ever!?
Thanks to .net, as a single, full-stack solution Items might set record for native UX runtime targets and potential device reach by platform!  Think of it this way: 
Segment	Platform	Active Devices Q2 2018 (millions)*
Mobile	 iOS	1300
	 Android	2000
	
Desktop	 Windows 10	550
	 MacOS 	68
	 Linux	6
	
Living Room	 XBox One	48
	 Samsung Smart TVs	133
	
Grand Total	4,109
*Estimates from Statista.com sources. Linux desktop is “WAG”!
Want to reach 4.1 Billion active device users on Mobile, Desktop and in the Living Room?  This single .net solution delivers *native* UX, device/cloud persistence and no vendor lock. 
How is This Solution Better?
Items is just an an alternative vision of the latest “Cross-Platform Solution” template for Visual Studio (Windows or Mac).  Items tweaks the current solution template to include:
•	A separate and “better” persistence model demonstrating always on local persistence with optional, cloud-powered backend persistence and synch
•	A more consistent use of best patterns and practices so the solution can take developers from zero to “enterprise” and/or “app store” grade apps
•	The ability to leverage common code “features” across both Xamarin Native and Xamarin Forms projects in the same solution 
Requiring the Items solution to support both Xamarin Forms and Xamarin Native makes it easier for folks that want to use Xamarin Forms for rapid application and MVP development.  If they choose, they can move directly to Xamarin Native development for iOS, Android and Windows Universal without retooling the persistence.  
Adding Authentication, App Telemetry and Notifications and other “App Features”
The default Apps projects in the solution add just enough stubbed methods and related properties to also let you easily and incrementally add:
•	Authentication / 3rd-Party Authentication
•	App Telemetry
•	Notifications 
To add features, you add “Cross-Platform Feature Projects” to the Solution, like:
•	Cross-Platform Feature: Authentication (with Xamarin Auth)
•	Cross-Platform Feature: App Telemetry (with App Center)
•	Cross-Platform Feature: Notifications (with ASP.NET Core)
Using dependency-injection the same “feature projects” runtimes are designed to work with both Xamarin Native and Xamarin Forms clients.  And hopefully, the roster of extensible “Cross-Platform Features” projects can grow, bringing the utility of libraries and plugins with the “eyes on code” and “I can fix this” flexibility of projects.  This code you can step through, understand and customize.
No Lock In
While these Cross-Platform Feature projects use Azure-driven backend resources, as open source code they also demonstrate how to achieve the same features using other providers.  Presumably folks will demo “cross-platform feature projects” for third-party vendors, like Auth0. 
The solution projects are organized by solution folder:
•	Apps (Xamarin Forms)
•	Data and Persistence
In a future release I’ll be adding:
•	Apps (Xamarin Native)
•	Apps (Tizen and XBox)
•	Apps (Wearables)
Unless noted or required otherwise all projects target .net standard 2 for broadest device compatibility.
Persistence is an App Cornerstone – that Starts on Device using SQLite
Unlike the current Cross-Platform Solution, Items assumes that every app developer wants data persistence.  It also presumes that app persistence should start at the device rather than the cloud. Why? Device-based persistence gets developers up and running more quickly.  There’s simply less to configure. 
Defaulting to device-based persistence means every app gets the desirable “works offline, too” feature by default.  It’s just better.
And yes, there’s cloud sync, too.
This solution still provides a straight to Azure cloud implementation for backend persistence, but it’s now written with enough abstraction to also let people “plug in” their own persistence preferences or move to even newer Azure-driven solutions like CosmosDB without refactoring the whole app. (You could even use something other than Azure - but why would you ?)
Device-Side Persistence	Cloud Persistence for Sync
SQLite with Entity Framework Core	ASP.NET Core REST API with EF Core and SQL Server 
(publish to Azure or host on your own)

The Items solution separates out the Models and related DataStore persistence handling in the existing solution from the Xamarin Forms (“XF”) project into two standalone projects:
•	Items.DataModels
•	Items.DataStores
The DataStores project uses the familiar, open-source Entity Framework persistence frameworks for data access.  But, because of reasonable implementation of the Repository pattern it’s a straightforward affair to replace the Local or Remote persistence Repositories – even with something other than Entity Framework.
[DOCUMENT IN PROGRESS]
