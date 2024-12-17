using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.TickableWorldSubsystem")]
	public partial class UTickableWorldSubsystem : UWorldSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.TickableWorldSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}