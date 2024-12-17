using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.Interface_AnimCurveMetaData")]
	public partial class UInterface_AnimCurveMetaData : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.Interface_AnimCurveMetaData");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.Interface_AnimCurveMetaData")]
	public interface IInterface_AnimCurveMetaData : IInterface
	{
	}
}