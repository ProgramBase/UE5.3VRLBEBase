using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.WidgetBinaryStateRegistration")]
	public partial class UWidgetBinaryStateRegistration : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.WidgetBinaryStateRegistration");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}