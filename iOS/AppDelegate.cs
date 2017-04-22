using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace TestListViewMultiSelectItems.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			LoadApplication(new App());

			var x = typeof(Behaviors.EventHandlerBehavior);

			return base.FinishedLaunching(app, options);
		}
	}
}
