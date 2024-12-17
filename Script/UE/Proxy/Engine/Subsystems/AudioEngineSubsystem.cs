using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AudioEngineSubsystem")]
	public partial class UAudioEngineSubsystem : UDynamicSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AudioEngineSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}