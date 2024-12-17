using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ActorFactoryInteractiveFoliage")]
	public partial class UActorFactoryInteractiveFoliage : UActorFactoryStaticMesh, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ActorFactoryInteractiveFoliage");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}