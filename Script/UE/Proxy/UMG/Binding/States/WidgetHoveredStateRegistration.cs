using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.WidgetHoveredStateRegistration")]
	public partial class UWidgetHoveredStateRegistration : UWidgetBinaryStateRegistration, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.WidgetHoveredStateRegistration");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}