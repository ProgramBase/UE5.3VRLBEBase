using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ActorFactoryPlaneReflectionCapture")]
	public partial class UActorFactoryPlaneReflectionCapture : UActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ActorFactoryPlaneReflectionCapture");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}