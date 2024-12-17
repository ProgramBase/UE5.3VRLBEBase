using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldSubsystem")]
	public partial class UWorldSubsystem : USubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.WorldSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}