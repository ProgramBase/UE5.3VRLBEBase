using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.MaterialGraphNode_PinBase")]
	public partial class UMaterialGraphNode_PinBase : UMaterialGraphNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.MaterialGraphNode_PinBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}