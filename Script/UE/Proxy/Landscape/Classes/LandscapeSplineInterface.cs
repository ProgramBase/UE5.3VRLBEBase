using Script.CoreUObject;
using Script.Library;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.LandscapeSplineInterface")]
	public partial class ULandscapeSplineInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Landscape.LandscapeSplineInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Landscape.LandscapeSplineInterface")]
	public interface ILandscapeSplineInterface : IInterface
	{
	}
}