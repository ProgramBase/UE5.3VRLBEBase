using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.NativeWidgetHost")]
	public partial class UNativeWidgetHost : UWidget, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.NativeWidgetHost");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}