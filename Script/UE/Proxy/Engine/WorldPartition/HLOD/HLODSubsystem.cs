using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.HLODSubsystem")]
	public partial class UHLODSubsystem : UWorldSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.HLODSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}