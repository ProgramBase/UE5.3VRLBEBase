using Script.CoreUObject;
using Script.InterchangeEngine;
using Script.Library;

namespace Script.InterchangeEditorUtilities
{
	[PathName("/Script/InterchangeEditorUtilities.InterchangeFilePickerGeneric")]
	public partial class UInterchangeFilePickerGeneric : UInterchangeFilePickerBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeEditorUtilities.InterchangeFilePickerGeneric");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}