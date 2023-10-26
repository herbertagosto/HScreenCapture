
# HScreenCapture

Simple screen and window capture

<a href="https://www.paypal.me/herbertagosto">
	<img src="https://img.shields.io/badge/$-donate-ff69b4.svg?maxAge=2592000&amp;style=flat">
</a>

## Getting Started

```
private void button1_Click(object sender, EventArgs e)
{
	// Initialize HScreenCapture class
	HScreenCapture.Main hsc = new HScreenCapture.Main();

	// Screen capture a window
	// Use Microsoft Spy++ to get the window class and caption
	// Sample window Class from Spy++: "Notepad"
	// Sample window caption from Spy++: "*Untitled - Notepad" 
	var image = hsc.GetImage("Notepad", "*Untitled - Notepad");

	// Save image to clipboard
	hsc.SaveToClipboard(image);
}
```

```
# API:
HScreenCapture.Main hsc = new HScreenCapture.Main();

// To screen capture a screen
var image = hsc.GetImage();

// To screen capture a window
// Use Microsoft Spy++ to get the windowClassName & windowMainTitle
var image = hsc.GetImage(windowClassName, windowMainTitle);

// To save image to clipboard
hsc.SaveToClipboard(image);

// To save image to PNG
hsc.SaveToPNG(filePath, image);

// To save image to file
hsc.SaveToFile(filePath, image, ImageFormat.Png);
```

### Common Error
GDI+ Error: Occurs when the window class name and main title are incorrect.

![Sample GDI+ error](https://github.com/herbertagosto/HScreenCapture/blob/main/Resources/generic-gdi+-error.png)


### Microsoft Spy++
![Sample Spy++ data](https://github.com/herbertagosto/HScreenCapture/blob/main/Resources/spy++.png)


### Prerequisities

.NET Framework 4.5


### Installing

https://www.nuget.org/packages/HScreenCapture/


## Built With

Visual Studio 2017


## License

See [LICENSE](https://github.com/herbertagosto/HScreenCapture/blob/main/LICENSE.md) file


## Github

https://github.com/herbertagosto/HScreenCapture


## Support

<a href="https://www.buymeacoffee.com/hagosto" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/purple_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>