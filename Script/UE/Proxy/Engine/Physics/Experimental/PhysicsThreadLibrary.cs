using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PhysicsThreadLibrary")]
	public partial class UPhysicsThreadLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PhysicsThreadLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Force">
		/// Force vector to apply. Magnitude indicates strength of force.
		/// </param>
		/// <param name="bAccelChange">
		/// If true, Force is taken as a change in acceleration instead of a physical force (i.e. mass will have no effect).
		/// </param>
		public static void AddForce(FBodyInstanceAsyncPhysicsTickHandle Handle, FVector Force, bool bAccelChange = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Handle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Force?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bAccelChange;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AddForce, __InBuffer);
			}
		}

		private static uint __AddForce = 0;
	}
}