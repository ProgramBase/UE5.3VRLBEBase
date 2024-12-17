using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.VisualLoggerExtension")]
	public partial class UVisualLoggerExtension : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.VisualLoggerExtension");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}