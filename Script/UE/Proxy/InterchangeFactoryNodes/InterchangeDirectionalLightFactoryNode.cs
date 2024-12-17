using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeFactoryNodes
{
	[PathName("/Script/InterchangeFactoryNodes.InterchangeDirectionalLightFactoryNode")]
	public partial class UInterchangeDirectionalLightFactoryNode : UInterchangeBaseLightFactoryNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeFactoryNodes.InterchangeDirectionalLightFactoryNode");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}