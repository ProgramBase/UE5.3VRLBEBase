using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimPreviewAttacheInstance")]
	public partial class UAnimPreviewAttacheInstance : UAnimInstance, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimPreviewAttacheInstance");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}