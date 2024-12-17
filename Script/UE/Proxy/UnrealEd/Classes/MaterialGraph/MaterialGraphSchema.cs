using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.MaterialGraphSchema")]
	public partial class UMaterialGraphSchema : UEdGraphSchema, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.MaterialGraphSchema");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}