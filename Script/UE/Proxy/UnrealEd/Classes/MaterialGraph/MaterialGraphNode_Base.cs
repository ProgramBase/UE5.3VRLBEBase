using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.MaterialGraphNode_Base")]
	public partial class UMaterialGraphNode_Base : UEdGraphNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.MaterialGraphNode_Base");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}