using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.WidgetCheckedStateRegistration")]
	public partial class UWidgetCheckedStateRegistration : UWidgetEnumStateRegistration, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.WidgetCheckedStateRegistration");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}