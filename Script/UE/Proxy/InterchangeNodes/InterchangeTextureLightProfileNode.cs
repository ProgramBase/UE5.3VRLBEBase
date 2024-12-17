using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeNodes
{
	[PathName("/Script/InterchangeNodes.InterchangeTextureLightProfileNode")]
	public partial class UInterchangeTextureLightProfileNode : UInterchangeTextureNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeNodes.InterchangeTextureLightProfileNode");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}