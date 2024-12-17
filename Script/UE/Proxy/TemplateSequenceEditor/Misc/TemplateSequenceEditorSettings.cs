using Script.CoreUObject;
using Script.Library;

namespace Script.TemplateSequenceEditor
{
	[PathName("/Script/TemplateSequenceEditor.TemplateSequenceEditorSettings")]
	public partial class UTemplateSequenceEditorSettings : UObject, IStaticClass
	{
		public bool bShowOutdatedAssetsInCameraAnimationTrackEditor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowOutdatedAssetsInCameraAnimationTrackEditor, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowOutdatedAssetsInCameraAnimationTrackEditor, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TemplateSequenceEditor.TemplateSequenceEditorSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bShowOutdatedAssetsInCameraAnimationTrackEditor = 0;
	}
}