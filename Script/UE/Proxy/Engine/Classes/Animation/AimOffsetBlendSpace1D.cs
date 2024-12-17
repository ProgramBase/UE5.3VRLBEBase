using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AimOffsetBlendSpace1D")]
	public partial class UAimOffsetBlendSpace1D : UBlendSpace1D, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AimOffsetBlendSpace1D");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}