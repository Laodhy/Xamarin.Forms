using System.Reflection;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

#if !MXBUILD
[assembly: AssemblyTitle("Xamarin.Forms.Core")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCulture("")]
#endif

// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The Page "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.

//[assembly: AssemblyVersion("1.0.*")]

// The following attributes are used to specify the signing key for the assembly, 
// if desired. See the Mono documentation for more information about signing.

//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]

#if !MXBUILD
[assembly: InternalsVisibleTo("Xamarin.Forms.Platform.iOS")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Platform.iOS.Classic")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Platform.Android")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Platform.UAP")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Platform.WinRT")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Platform.WinRT.Tablet")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Platform.WinRT.Phone")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Platform.WP8")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Platform.MacOS")]
#else
[assembly: InternalsVisibleTo("Xamarin.Forms.Portable")]
[assembly: InternalsVisibleTo("Xamarin.Forms.ControlGallery")]
#endif
[assembly: InternalsVisibleTo("iOSUnitTests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Controls")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Core.Design")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Core.UnitTests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Core.Android.UnitTests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Core.WP8.UnitTests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Xaml")]
#if !MXBUILD
[assembly: InternalsVisibleTo("Xamarin.Forms.Maps")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Maps.iOS")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Maps.iOS.Classic")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Maps.Android")]
#endif
[assembly: InternalsVisibleTo("Xamarin.Forms.Xaml.UnitTests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.UITests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.ControlGallery.UITests")]

[assembly: InternalsVisibleTo("Xamarin.Forms.Core.iOS.UITests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Core.Android.UITests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Core.Windows.UITests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.iOS.UITests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Android.UITests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Loader")]
[assembly: InternalsVisibleTo("Xamarin.Forms.UITest.Validator")]
#if !MXBUILD
[assembly: InternalsVisibleTo("Xamarin.Forms.Build.Tasks")]
#else
[assembly: InternalsVisibleTo("Xamarin.Forms.Xaml.BuildTasks")]
#endif
[assembly: InternalsVisibleTo("Xamarin.Forms.Platform")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Pages")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Pages.UnitTests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.CarouselView")]

[assembly: XmlnsDefinition("http://xamarin.com/schemas/2014/forms", "Xamarin.Forms")]
#if !MXBUILD
[assembly: Preserve]
#endif
