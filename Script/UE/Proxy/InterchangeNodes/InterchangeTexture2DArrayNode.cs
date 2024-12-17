using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeNodes
{
	[PathName("/Script/InterchangeNodes.InterchangeTexture2DArrayNode")]
	public partial class UInterchangeTexture2DArrayNode : UInterchangeTextureNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeNodes.InterchangeTexture2DArrayNode");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}