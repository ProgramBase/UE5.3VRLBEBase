using Script.CoreUObject;

namespace Script.ModelingToolsEditorMode
{
	[PathName("/Script/ModelingToolsEditorMode.EModelingModeAssetGenerationBehavior")]
	public enum EModelingModeAssetGenerationBehavior : int
	{
		AutoGenerateAndAutosave = 0,
		AutoGenerateButDoNotAutosave = 1,
		InteractivePromptToSave = 2,
	}
}