using Script.CoreUObject;
using Script.Library;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.ViewportTransformer")]
	public partial class UViewportTransformer : UObject, IStaticClass
	{
		public UViewportWorldInteraction ViewportWorldInteraction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ViewportWorldInteraction, __ReturnBuffer);

					return *(UViewportWorldInteraction*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ViewportWorldInteraction, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ViewportInteraction.ViewportTransformer");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void Shutdown()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Shutdown);
			}
		}

		/// <returns>
		/// True if the transform gizmo should be aligned to the center of the bounds of all selected objects with more than one is selected.  Otherwise it will be at the pivot of the last transformable, similar to legacl editor actor selection */
		/// </returns>
		public virtual bool ShouldCenterTransformGizmoPivot()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __ShouldCenterTransformGizmoPivot, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void OnStopDragging(UViewportInteractor Interactor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Interactor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnStopDragging, __InBuffer);
			}
		}

		public virtual void OnStartDragging(UViewportInteractor Interactor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Interactor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnStartDragging, __InBuffer);
			}
		}

		public virtual void Init(UViewportWorldInteraction InitViewportWorldInteraction)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InitViewportWorldInteraction?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Init, __InBuffer);
			}
		}

		/// <returns>
		/// If this transformer can be used to align its transformable to actors in the scene */
		/// </returns>
		public virtual bool CanAlignToActors()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __CanAlignToActors, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __ViewportWorldInteraction = 0;

		private static uint __Shutdown = 0;

		private static uint __ShouldCenterTransformGizmoPivot = 0;

		private static uint __OnStopDragging = 0;

		private static uint __OnStartDragging = 0;

		private static uint __Init = 0;

		private static uint __CanAlignToActors = 0;
	}
}