using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeFactoryNodes
{
	[PathName("/Script/InterchangeFactoryNodes.InterchangeTextureCubeFactoryNode")]
	public partial class UInterchangeTextureCubeFactoryNode : UInterchangeTextureFactoryNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeFactoryNodes.InterchangeTextureCubeFactoryNode");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}