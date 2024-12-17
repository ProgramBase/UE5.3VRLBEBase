using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.SequencerAnimTools
{
	[PathName("/Script/SequencerAnimTools.SequencerToolsEditMode")]
	public partial class USequencerToolsEditMode : UBaseLegacyWidgetEdMode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequencerAnimTools.SequencerToolsEditMode");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}