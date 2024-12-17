using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.WidgetFieldNotificationExtension")]
	public partial class UWidgetFieldNotificationExtension : UUserWidgetExtension, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.WidgetFieldNotificationExtension");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}