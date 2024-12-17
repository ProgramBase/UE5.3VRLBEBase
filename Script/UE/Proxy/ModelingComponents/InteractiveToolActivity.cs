using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.InteractiveToolActivity")]
	public partial class UInteractiveToolActivity : UInteractionMechanic, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.InteractiveToolActivity");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}