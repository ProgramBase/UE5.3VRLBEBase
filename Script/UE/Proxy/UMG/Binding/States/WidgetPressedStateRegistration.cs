using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.WidgetPressedStateRegistration")]
	public partial class UWidgetPressedStateRegistration : UWidgetBinaryStateRegistration, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.WidgetPressedStateRegistration");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}