using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimCurveCompressionCodec_UniformIndexable")]
	public partial class UAnimCurveCompressionCodec_UniformIndexable : UAnimCurveCompressionCodec, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimCurveCompressionCodec_UniformIndexable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}