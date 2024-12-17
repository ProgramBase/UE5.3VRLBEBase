using Script.CoreUObject;
using Script.Library;

namespace Script.Persona
{
	[PathName("/Script/Persona.AnimAssetFindReplaceSyncMarkers")]
	public partial class UAnimAssetFindReplaceSyncMarkers : UAnimAssetFindReplaceProcessor_StringBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Persona.AnimAssetFindReplaceSyncMarkers");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}