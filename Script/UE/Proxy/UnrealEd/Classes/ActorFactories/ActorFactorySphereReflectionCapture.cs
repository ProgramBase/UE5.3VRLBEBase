using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ActorFactorySphereReflectionCapture")]
	public partial class UActorFactorySphereReflectionCapture : UActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ActorFactorySphereReflectionCapture");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}