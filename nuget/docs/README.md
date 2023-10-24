# HScreenCapture

Simple screen and window capture


## Getting Started

```
private void button1_Click(object sender, EventArgs e)
{
	// Initialize HScreenCapture class
	HScreenCapture.Main hsc = new HScreenCapture.Main();

	// Screen capture a window
	// Use Microsoft Spy++ to get the window class and caption
	// Sample window Class: "Notepad"
	// Sample window caption: "*Untitled - Notepad" 
	var image = hsc.GetImage("*Untitled - Notepad" "Notepad");

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

### Microsoft Spy++
![Sample Spy++](https://github.com/herbertagosto/HScreenCapture/blob/main/Resources/spy++.png)


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