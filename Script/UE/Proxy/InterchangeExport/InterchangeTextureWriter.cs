using Script.CoreUObject;
using Script.InterchangeCore;
using Script.Library;

namespace Script.InterchangeExport
{
	[PathName("/Script/InterchangeExport.InterchangeTextureWriter")]
	public partial class UInterchangeTextureWriter : UInterchangeWriterBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeExport.InterchangeTextureWriter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}