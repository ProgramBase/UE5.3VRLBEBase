using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Constraints
{
	[PathName("/Script/Constraints.ConstraintsActor")]
	public partial class AConstraintsActor : AActor, IStaticClass
	{
		public UConstraintsManager ConstraintsManager
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ConstraintsManager, __ReturnBuffer);

					return *(UConstraintsManager*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ConstraintsManager, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Constraints.ConstraintsActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ConstraintsManager = 0;
	}
}