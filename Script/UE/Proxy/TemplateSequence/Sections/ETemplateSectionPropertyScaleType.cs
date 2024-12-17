using Script.CoreUObject;

namespace Script.TemplateSequence
{
	[PathName("/Script/TemplateSequence.ETemplateSectionPropertyScaleType")]
	public enum ETemplateSectionPropertyScaleType : int
	{
		FloatProperty = 0,
		TransformPropertyLocationOnly = 1,
		TransformPropertyRotationOnly = 2,
	}
}