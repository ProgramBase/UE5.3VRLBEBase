using Script.CoreUObject;
using Script.Library;

namespace Script.Persona
{
	[PathName("/Script/Persona.AnimAssetFindReplaceProcessor")]
	public partial class UAnimAssetFindReplaceProcessor : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Persona.AnimAssetFindReplaceProcessor");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}