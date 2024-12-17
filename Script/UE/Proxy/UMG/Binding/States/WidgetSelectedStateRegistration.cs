using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.WidgetSelectedStateRegistration")]
	public partial class UWidgetSelectedStateRegistration : UWidgetBinaryStateRegistration, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.WidgetSelectedStateRegistration");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}