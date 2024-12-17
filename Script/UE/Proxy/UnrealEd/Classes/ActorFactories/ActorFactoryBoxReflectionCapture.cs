using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ActorFactoryBoxReflectionCapture")]
	public partial class UActorFactoryBoxReflectionCapture : UActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ActorFactoryBoxReflectionCapture");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}