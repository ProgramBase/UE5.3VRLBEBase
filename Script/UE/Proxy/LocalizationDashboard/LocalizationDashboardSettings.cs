using Script.CoreUObject;
using Script.Library;

namespace Script.LocalizationDashboard
{
	[PathName("/Script/LocalizationDashboard.LocalizationDashboardSettings")]
	public partial class ULocalizationDashboardSettings : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LocalizationDashboard.LocalizationDashboardSettings");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}