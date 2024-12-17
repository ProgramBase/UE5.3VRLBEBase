using Script.CoreUObject;
using Script.Library;

namespace Script.TemplateSequenceEditor
{
	[PathName("/Script/TemplateSequenceEditor.AssetDefinition_CameraAnimationSequence")]
	public partial class UAssetDefinition_CameraAnimationSequence : UAssetDefinition_TemplateSequence, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TemplateSequenceEditor.AssetDefinition_CameraAnimationSequence");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}