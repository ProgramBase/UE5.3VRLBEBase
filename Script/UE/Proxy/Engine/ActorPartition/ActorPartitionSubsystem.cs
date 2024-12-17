using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ActorPartitionSubsystem")]
	public partial class UActorPartitionSubsystem : UWorldSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ActorPartitionSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}