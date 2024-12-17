using Script.CoreUObject;
using Script.Library;

namespace Script.DetailCustomizations
{
	[PathName("/Script/DetailCustomizations.SplineMetadataDetailsFactoryBase")]
	public partial class USplineMetadataDetailsFactoryBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DetailCustomizations.SplineMetadataDetailsFactoryBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}