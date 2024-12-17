using Script.CoreUObject;
using Script.Library;

namespace Script.Persona
{
	[PathName("/Script/Persona.AnimAssetFindReplaceProcessor_StringBase")]
	public partial class UAnimAssetFindReplaceProcessor_StringBase : UAnimAssetFindReplaceProcessor, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Persona.AnimAssetFindReplaceProcessor_StringBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}