using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.BuiltInDynamicBindingResolverLibrary")]
	public partial class UBuiltInDynamicBindingResolverLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.BuiltInDynamicBindingResolverLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FMovieSceneDynamicBindingResolveResult ResolveToPlayerPawn(UObject WorldContextObject, int PlayerControllerIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = PlayerControllerIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ResolveToPlayerPawn, __InBuffer, __ReturnBuffer);

				return *(FMovieSceneDynamicBindingResolveResult*)__ReturnBuffer;
			}
		}

		private static uint __ResolveToPlayerPawn = 0;
	}
}