using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.VariantManagerContentEditor
{
	[PathName("/Script/VariantManagerContentEditor.LevelVariantSetsActorFactory")]
	public partial class ULevelVariantSetsActorFactory : UActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VariantManagerContentEditor.LevelVariantSetsActorFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}