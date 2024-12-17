using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.TemplateSequenceEditor
{
	[PathName("/Script/TemplateSequenceEditor.CameraAnimationSequenceFactoryNew")]
	public partial class UCameraAnimationSequenceFactoryNew : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TemplateSequenceEditor.CameraAnimationSequenceFactoryNew");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}