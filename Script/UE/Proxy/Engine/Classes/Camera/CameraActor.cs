using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CameraActor")]
	public partial class ACameraActor : AActor, IStaticClass
	{
		public EAutoReceiveInput AutoActivateForPlayer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AutoActivateForPlayer, __ReturnBuffer);

					return *(EAutoReceiveInput*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AutoActivateForPlayer, __InBuffer);
				}
			}
		}

		public UCameraComponent CameraComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CameraComponent, __ReturnBuffer);

					return *(UCameraComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CameraComponent, __InBuffer);
				}
			}
		}

		public USceneComponent SceneComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SceneComponent, __ReturnBuffer);

					return *(USceneComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SceneComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.CameraActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual int GetAutoActivatePlayerIndex()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetAutoActivatePlayerIndex, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __AutoActivateForPlayer = 0;

		private static uint __CameraComponent = 0;

		private static uint __SceneComponent = 0;

		private static uint __GetAutoActivatePlayerIndex = 0;
	}
}