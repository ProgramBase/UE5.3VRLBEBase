using Script.CoreUObject;
using Script.Library;

namespace Script.Persona
{
	[PathName("/Script/Persona.AnimAssetFindReplaceContext")]
	public partial class UAnimAssetFindReplaceContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Persona.AnimAssetFindReplaceContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}