using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.LifecycleEvents;
using Microsoft.Maui.Controls.Compatibility;

using Telerik.Maui;
using Telerik.Maui.Handlers;

// add the needed usings
#if __ANDROID__
using InputRenderer = Telerik.XamarinForms.InputRenderer.Android;
using ChartRenderer = Telerik.XamarinForms.ChartRenderer.Android;
using DataControlsRenderer = Telerik.XamarinForms.DataControlsRenderer.Android;
#elif __IOS__
using InputRenderer = Telerik.XamarinForms.InputRenderer.iOS;
using ChartRenderer = Telerik.XamarinForms.ChartRenderer.iOS;
using DataControlsRenderer = Telerik.XamarinForms.DataControlsRenderer.iOS;
#endif

namespace PokedexApp
{
	public class Startup : IStartup
	{
		public void Configure(IAppHostBuilder appBuilder)
		{
			appBuilder
				.UseFormsCompatibility()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				})
                .ConfigureMauiHandlers(handlers => {
                    // ****** Compatibility Renderers ***** //
                    
                    // Compatibillity renderer for Telerik UI for MAUI Button control
                    handlers.AddCompatibilityRenderer(typeof(Telerik.XamarinForms.Input.RadButton), typeof(InputRenderer.ButtonRenderer));
                    
                    // Compatibillity renderer for Telerik UI for MAUI RadCartesianChart control
                    handlers.AddCompatibilityRenderer(typeof(Telerik.XamarinForms.Chart.RadCartesianChart), typeof(ChartRenderer.CartesianChartRenderer));

                    // Compatibillity renderer for Telerik UI for MAUI RadPieChart control
                    handlers.AddCompatibilityRenderer(typeof(Telerik.XamarinForms.Chart.RadPieChart), typeof(ChartRenderer.PieChartRenderer));
                    
                    // Compatibillity renderer for Telerik UI for MAUI RadListView control
                    handlers.AddCompatibilityRenderer(typeof(Telerik.XamarinForms.DataControls.RadListView), 
                        typeof(DataControlsRenderer.ListViewRenderer));

                    // ****** Handlers ***** //       

                    // Add the Telerik UI for MAUI Handlers for ItemsControl control
                    handlers.AddHandler<IRadItemsControl, RadItemsControlHandler>();

                    // Add the handlers for Telerik UI for MAUI Border control
                    handlers.AddHandler<IRadBorder, RadBorderHandler>();
                })
                .UseMauiApp<App>()
                .ConfigureLifecycleEvents(lifecycle => {
                    #if ANDROID
                    lifecycle.AddAndroid(d => {
                        d.OnBackPressed(activity => {
                            System.Diagnostics.Debug.WriteLine("Back button pressed!");
                        });
                    });
                    #endif
                });
        }
	}
}