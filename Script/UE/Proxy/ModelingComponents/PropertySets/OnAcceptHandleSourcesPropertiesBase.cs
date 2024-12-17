using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.OnAcceptHandleSourcesPropertiesBase")]
	public partial class UOnAcceptHandleSourcesPropertiesBase : UInteractiveToolPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.OnAcceptHandleSourcesPropertiesBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}