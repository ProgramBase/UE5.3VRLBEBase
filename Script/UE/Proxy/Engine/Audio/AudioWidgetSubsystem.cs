using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AudioWidgetSubsystem")]
	public partial class UAudioWidgetSubsystem : UEngineSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AudioWidgetSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}