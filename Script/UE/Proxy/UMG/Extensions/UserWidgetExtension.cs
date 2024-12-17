using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.UserWidgetExtension")]
	public partial class UUserWidgetExtension : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.UserWidgetExtension");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}