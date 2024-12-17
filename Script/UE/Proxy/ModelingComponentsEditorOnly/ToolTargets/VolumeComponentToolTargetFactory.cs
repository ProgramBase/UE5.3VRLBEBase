using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.ModelingComponentsEditorOnly
{
	[PathName("/Script/ModelingComponentsEditorOnly.VolumeComponentToolTargetFactory")]
	public partial class UVolumeComponentToolTargetFactory : UToolTargetFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponentsEditorOnly.VolumeComponentToolTargetFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}