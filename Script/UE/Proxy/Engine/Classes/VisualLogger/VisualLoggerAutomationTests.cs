using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.VisualLoggerAutomationTests")]
	public partial class UVisualLoggerAutomationTests : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.VisualLoggerAutomationTests");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}