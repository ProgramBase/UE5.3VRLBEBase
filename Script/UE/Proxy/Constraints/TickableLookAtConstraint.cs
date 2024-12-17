using Script.CoreUObject;
using Script.Library;

namespace Script.Constraints
{
	[PathName("/Script/Constraints.TickableLookAtConstraint")]
	public partial class UTickableLookAtConstraint : UTickableTransformConstraint, IStaticClass
	{
		public FVector Axis
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Axis, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Axis, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Constraints.TickableLookAtConstraint");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Axis = 0;
	}
}