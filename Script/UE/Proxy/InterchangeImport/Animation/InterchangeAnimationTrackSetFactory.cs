using Script.CoreUObject;
using Script.InterchangeCore;
using Script.Library;

namespace Script.InterchangeImport
{
	[PathName("/Script/InterchangeImport.InterchangeAnimationTrackSetFactory")]
	public partial class UInterchangeAnimationTrackSetFactory : UInterchangeFactoryBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeImport.InterchangeAnimationTrackSetFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}