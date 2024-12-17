using Script.CoreUObject;
using Script.Library;

namespace Script.TemplateSequence
{
	[PathName("/Script/TemplateSequence.CameraAnimationSequence")]
	public partial class UCameraAnimationSequence : UTemplateSequence, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TemplateSequence.CameraAnimationSequence");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}