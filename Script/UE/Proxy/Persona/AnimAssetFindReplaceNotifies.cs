using Script.CoreUObject;
using Script.Library;

namespace Script.Persona
{
	[PathName("/Script/Persona.AnimAssetFindReplaceNotifies")]
	public partial class UAnimAssetFindReplaceNotifies : UAnimAssetFindReplaceProcessor_StringBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Persona.AnimAssetFindReplaceNotifies");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}