using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimCurveCompressionCodec")]
	public partial class UAnimCurveCompressionCodec : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimCurveCompressionCodec");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}