using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.MaterialGraphNode_Knot")]
	public partial class UMaterialGraphNode_Knot : UMaterialGraphNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.MaterialGraphNode_Knot");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}