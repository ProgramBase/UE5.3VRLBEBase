using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.HLODEngineSubsystem")]
	public partial class UHLODEngineSubsystem : UEngineSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.HLODEngineSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}