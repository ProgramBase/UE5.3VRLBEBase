using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.TemplateSequenceEditor
{
	[PathName("/Script/TemplateSequenceEditor.AssetDefinition_TemplateSequence")]
	public partial class UAssetDefinition_TemplateSequence : UAssetDefinitionDefault, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TemplateSequenceEditor.AssetDefinition_TemplateSequence");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}