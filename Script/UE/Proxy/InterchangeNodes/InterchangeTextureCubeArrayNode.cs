using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeNodes
{
	[PathName("/Script/InterchangeNodes.InterchangeTextureCubeArrayNode")]
	public partial class UInterchangeTextureCubeArrayNode : UInterchangeTextureNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeNodes.InterchangeTextureCubeArrayNode");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}