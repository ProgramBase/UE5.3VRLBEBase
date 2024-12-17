using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.WidgetEnumStateRegistration")]
	public partial class UWidgetEnumStateRegistration : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.WidgetEnumStateRegistration");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}