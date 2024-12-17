using Script.CoreUObject;
using Script.AnimationCore;
using Script.Library;

namespace Script.Constraints
{
	[PathName("/Script/Constraints.TickableTranslationConstraint")]
	public partial class UTickableTranslationConstraint : UTickableTransformConstraint, IStaticClass
	{
		public FVector OffsetTranslation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OffsetTranslation, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OffsetTranslation, __InBuffer);
				}
			}
		}

		public FFilterOptionPerAxis AxisFilter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AxisFilter, __ReturnBuffer);

					return *(FFilterOptionPerAxis*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AxisFilter, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Constraints.TickableTranslationConstraint");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __OffsetTranslation = 0;

		private static uint __AxisFilter = 0;
	}
}