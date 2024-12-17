using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.IntervalGizmoActor")]
	public partial class AIntervalGizmoActor : AGizmoActor, IStaticClass
	{
		public UGizmoLineHandleComponent UpIntervalComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UpIntervalComponent, __ReturnBuffer);

					return *(UGizmoLineHandleComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UpIntervalComponent, __InBuffer);
				}
			}
		}

		public UGizmoLineHandleComponent DownIntervalComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DownIntervalComponent, __ReturnBuffer);

					return *(UGizmoLineHandleComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DownIntervalComponent, __InBuffer);
				}
			}
		}

		public UGizmoLineHandleComponent ForwardIntervalComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ForwardIntervalComponent, __ReturnBuffer);

					return *(UGizmoLineHandleComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ForwardIntervalComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.IntervalGizmoActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __UpIntervalComponent = 0;

		private static uint __DownIntervalComponent = 0;

		private static uint __ForwardIntervalComponent = 0;
	}
}