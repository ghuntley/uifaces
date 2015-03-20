![](http://uifaces.com/assets/static/images/logo.svg?1380758882)
# UIFaces

UIFaces removes the toil of finding sample avatars for UI mockups/concepts.

# Supported Platforms

* .NET 4.5 (We are a Profile78 Portable Class Library)
* Mono
* Xamarin.iOS
* Xamarin.Android
* Xamarin.Mac

# Installation
Installation is done via NuGet:

	Install-Package UIFaces

# Usage

	var client = RestService.For<IUIFaces>("http://uifaces.com/api");
	UIFace face = await client.Random();

	<img src="{face.ImageUrl.Normal}"/>

Refer to http://uifaces.com/faq for more details.
