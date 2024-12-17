using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimCompress_LeastDestructive")]
	public partial class UAnimCompress_LeastDestructive : UAnimCompress_BitwiseCompressOnly, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimCompress_LeastDestructive");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}