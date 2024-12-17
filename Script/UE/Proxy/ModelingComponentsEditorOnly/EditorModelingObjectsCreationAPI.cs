using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.ModelingComponentsEditorOnly
{
	[PathName("/Script/ModelingComponentsEditorOnly.EditorModelingObjectsCreationAPI")]
	public partial class UEditorModelingObjectsCreationAPI : UModelingObjectsCreationAPI, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponentsEditorOnly.EditorModelingObjectsCreationAPI");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}