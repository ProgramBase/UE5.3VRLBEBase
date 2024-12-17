using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.LandscapeEditor
{
	[PathName("/Script/LandscapeEditor.ActorFactoryLandscape")]
	public partial class UActorFactoryLandscape : UActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LandscapeEditor.ActorFactoryLandscape");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}