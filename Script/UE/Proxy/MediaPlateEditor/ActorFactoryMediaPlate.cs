using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.MediaPlateEditor
{
	[PathName("/Script/MediaPlateEditor.ActorFactoryMediaPlate")]
	public partial class UActorFactoryMediaPlate : UActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MediaPlateEditor.ActorFactoryMediaPlate");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}