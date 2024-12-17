using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.UMG
{
	[PathName("/Script/UMG.Viewport")]
	public partial class UViewport : UContentWidget, IStaticClass
	{
		public FLinearColor BackgroundColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BackgroundColor, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BackgroundColor, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.Viewport");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual AActor Spawn(TSubclassOf<AActor> ActorClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ActorClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __Spawn, __InBuffer, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		public virtual void SetViewRotation(FRotator Rotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetViewRotation, __InBuffer);
			}
		}

		public virtual void SetViewLocation(FVector Location)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Location?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetViewLocation, __InBuffer);
			}
		}

		public virtual FRotator GetViewRotation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetViewRotation, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public virtual UWorld GetViewportWorld()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetViewportWorld, __ReturnBuffer);

				return *(UWorld*)__ReturnBuffer;
			}
		}

		public virtual FVector GetViewLocation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetViewLocation, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		private static uint __BackgroundColor = 0;

		private static uint __Spawn = 0;

		private static uint __SetViewRotation = 0;

		private static uint __SetViewLocation = 0;

		private static uint __GetViewRotation = 0;

		private static uint __GetViewportWorld = 0;

		private static uint __GetViewLocation = 0;
	}
}