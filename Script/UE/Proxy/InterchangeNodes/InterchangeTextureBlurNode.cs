using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeNodes
{
	[PathName("/Script/InterchangeNodes.InterchangeTextureBlurNode")]
	public partial class UInterchangeTextureBlurNode : UInterchangeTexture2DNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeNodes.InterchangeTextureBlurNode");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}