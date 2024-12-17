using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.PolyEditExtrudeActivity")]
	public partial class UPolyEditExtrudeActivity : UInteractiveToolActivity, IStaticClass
	{
		public UPolyEditExtrudeProperties ExtrudeProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ExtrudeProperties, __ReturnBuffer);

					return *(UPolyEditExtrudeProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ExtrudeProperties, __InBuffer);
				}
			}
		}

		public UPolyEditOffsetProperties OffsetProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OffsetProperties, __ReturnBuffer);

					return *(UPolyEditOffsetProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OffsetProperties, __InBuffer);
				}
			}
		}

		public UPolyEditPushPullProperties PushPullProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PushPullProperties, __ReturnBuffer);

					return *(UPolyEditPushPullProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PushPullProperties, __InBuffer);
				}
			}
		}

		public UPlaneDistanceFromHitMechanic ExtrudeHeightMechanic
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ExtrudeHeightMechanic, __ReturnBuffer);

					return *(UPlaneDistanceFromHitMechanic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ExtrudeHeightMechanic, __InBuffer);
				}
			}
		}

		public UPolyEditActivityContext ActivityContext
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActivityContext, __ReturnBuffer);

					return *(UPolyEditActivityContext*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActivityContext, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.PolyEditExtrudeActivity");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ExtrudeProperties = 0;

		private static uint __OffsetProperties = 0;

		private static uint __PushPullProperties = 0;

		private static uint __ExtrudeHeightMechanic = 0;

		private static uint __ActivityContext = 0;
	}
}