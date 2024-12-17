using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeNodes
{
	[PathName("/Script/InterchangeNodes.InterchangeTextureCubeNode")]
	public partial class UInterchangeTextureCubeNode : UInterchangeTextureNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeNodes.InterchangeTextureCubeNode");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}