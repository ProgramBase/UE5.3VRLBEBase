using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.WidgetDisabledStateRegistration")]
	public partial class UWidgetDisabledStateRegistration : UWidgetBinaryStateRegistration, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.WidgetDisabledStateRegistration");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}