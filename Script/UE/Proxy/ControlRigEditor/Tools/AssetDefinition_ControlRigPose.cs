using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.AssetDefinition_ControlRigPose")]
	public partial class UAssetDefinition_ControlRigPose : UAssetDefinitionDefault, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRigEditor.AssetDefinition_ControlRigPose");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}