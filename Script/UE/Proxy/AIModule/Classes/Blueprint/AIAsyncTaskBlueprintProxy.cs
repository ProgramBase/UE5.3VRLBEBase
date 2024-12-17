using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AIAsyncTaskBlueprintProxy")]
	public partial class UAIAsyncTaskBlueprintProxy : UObject, IStaticClass
	{
		public FOAISimpleDelegate OnSuccess
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnSuccess, __ReturnBuffer);

					return *(FOAISimpleDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnSuccess, __InBuffer);
				}
			}
		}

		public FOAISimpleDelegate OnFail
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnFail, __ReturnBuffer);

					return *(FOAISimpleDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnFail, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.AIAsyncTaskBlueprintProxy");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void OnMoveCompleted(FAIRequestID RequestID, EPathFollowingResult MovementResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = RequestID?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)MovementResult;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnMoveCompleted, __InBuffer);
			}
		}

		private static uint __OnSuccess = 0;

		private static uint __OnFail = 0;

		private static uint __OnMoveCompleted = 0;
	}
}