using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ActorFactoryBasicShape")]
	public partial class UActorFactoryBasicShape : UActorFactoryStaticMesh, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ActorFactoryBasicShape");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}