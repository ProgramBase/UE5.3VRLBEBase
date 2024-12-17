using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeFactoryNodes
{
	[PathName("/Script/InterchangeFactoryNodes.InterchangeTextureCubeArrayFactoryNode")]
	public partial class UInterchangeTextureCubeArrayFactoryNode : UInterchangeTextureFactoryNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeFactoryNodes.InterchangeTextureCubeArrayFactoryNode");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}