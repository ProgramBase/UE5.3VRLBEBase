using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionTextureSampleParameterVolume")]
	public partial class UMaterialExpressionTextureSampleParameterVolume : UMaterialExpressionTextureSampleParameter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionTextureSampleParameterVolume");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}