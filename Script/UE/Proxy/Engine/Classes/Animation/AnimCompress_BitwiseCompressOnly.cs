using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimCompress_BitwiseCompressOnly")]
	public partial class UAnimCompress_BitwiseCompressOnly : UAnimCompress, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimCompress_BitwiseCompressOnly");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}