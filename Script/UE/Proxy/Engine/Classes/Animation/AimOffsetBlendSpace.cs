using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AimOffsetBlendSpace")]
	public partial class UAimOffsetBlendSpace : UBlendSpace, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AimOffsetBlendSpace");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}