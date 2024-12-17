using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CameraLensEffectInterfaceClassSupportLibrary")]
	public partial class UCameraLensEffectInterfaceClassSupportLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.CameraLensEffectInterfaceClassSupportLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Class">
		/// MUST implement CameraLensEffectInterface - when connecting variables to the input, take care that the input class does in fact implement the interface.
		/// </param>
		/// <param name="Var">
		/// The wrapper (for validation purposes) of the lens effect class.
		/// </param>
		public static void SetInterfaceClass(TSubclassOf<AActor> Class, ref FCameraLensInterfaceClassSupport Var, ref EInterfaceValidResult Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Class?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Var?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)Result;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetInterfaceClass, __InBuffer, __OutBuffer);

				Var = *(FCameraLensInterfaceClassSupport*)(__OutBuffer);

				Result = *(EInterfaceValidResult*)(__OutBuffer + 8);

			}
		}

		public static void IsInterfaceValid(TScriptInterface<ICameraLensEffectInterface> CameraLens, ref EInterfaceValidResult Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = CameraLens?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Result;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __IsInterfaceValid, __InBuffer, __OutBuffer);

				Result = *(EInterfaceValidResult*)(__OutBuffer);

			}
		}

		public static void IsInterfaceClassValid(FCameraLensInterfaceClassSupport CameraLens, ref EInterfaceValidResult Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = CameraLens?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Result;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __IsInterfaceClassValid, __InBuffer, __OutBuffer);

				Result = *(EInterfaceValidResult*)(__OutBuffer);

			}
		}

		public static TSubclassOf<AActor> GetInterfaceClass(FCameraLensInterfaceClassSupport CameraLens)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = CameraLens?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetInterfaceClass, __InBuffer, __ReturnBuffer);

				return *(TSubclassOf<AActor>*)__ReturnBuffer;
			}
		}

		private static uint __SetInterfaceClass = 0;

		private static uint __IsInterfaceValid = 0;

		private static uint __IsInterfaceClassValid = 0;

		private static uint __GetInterfaceClass = 0;
	}
}