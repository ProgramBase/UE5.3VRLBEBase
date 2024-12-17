using Script.CoreUObject;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.ENiagaraNamespaceMetadataOptions")]
	public enum ENiagaraNamespaceMetadataOptions : int
	{
		HideInScript = 0,
		HideInSystem = 1,
		AdvancedInScript = 2,
		AdvancedInSystem = 3,
		PreventEditingNamespace = 4,
		PreventEditingNamespaceModifier = 5,
		PreventEditingName = 6,
		PreventCreatingInSystemEditor = 7,
		HideInDefinitions = 8,
	}
}