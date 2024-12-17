using Script.CoreUObject;
using Script.Persona;
using Script.Library;

namespace Script.BlendSpaceMotionAnalysis
{
	[PathName("/Script/BlendSpaceMotionAnalysis.CachedMotionAnalysisProperties")]
	public partial class UCachedMotionAnalysisProperties : UCachedAnalysisProperties, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlendSpaceMotionAnalysis.CachedMotionAnalysisProperties");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}