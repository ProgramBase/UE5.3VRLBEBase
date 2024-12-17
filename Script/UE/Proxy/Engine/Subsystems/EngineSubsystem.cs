using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.EngineSubsystem")]
	public partial class UEngineSubsystem : UDynamicSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.EngineSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}