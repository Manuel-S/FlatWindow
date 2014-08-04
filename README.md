FlatWindow
==========

A reusable, simple flat window control for WPF

**Screenshot:**

![screenshot](screenshot.png)

**Usage:**

<pre class="nuget-button">Install-Package FlatWindow</pre>

Add a new Window to your project, then remove the inheritance (`: Window`) in the .cs file and replace the XAML. The files should look like this:

```csharp
	public partial class MainWindow
	{
		public MainWindow()
		{
			InitializeComponent();
		}
	}
```

```xml
<simply:FlatWindow x:Class="WindowTest.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:simply="clr-namespace:Simply;assembly=FlatWindow"
        Title="My Flat Window" Height="250" Width="450">
	<Grid>
		<TextBlock Text="Here goes the content!"/>
	</Grid>
</simply:FlatWindow>
```

cheers!

**Customize:**

Add Brushes with the Keys "WindowBackground" and "CaptionColor" to your window resource dictionary
```xml
<SolidColorBrush x:Key="WindowBackground" Color="Black" />
<SolidColorBrush x:Key="CaptionColor" Color="White" />
```


**Credit:**

* WPF Shell Integration Library
* [BorderLess Window](http://wpfborderless.codeplex.com/)
* Some other article I can't find anymore

<script type="text/javascript">
    (function () {
        var nb = document.createElement('script'); nb.type = 'text/javascript'; nb.async = true;
        nb.src = 'http://s.prabir.me/nuget-button/0.2.1/nuget-button.min.js';
        var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(nb, s);
    })();
</script>
