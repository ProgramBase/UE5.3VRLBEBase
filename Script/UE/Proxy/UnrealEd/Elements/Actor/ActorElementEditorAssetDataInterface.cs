using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ActorElementEditorAssetDataInterface")]
	public partial class UActorElementEditorAssetDataInterface : UActorElementAssetDataInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ActorElementEditorAssetDataInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}