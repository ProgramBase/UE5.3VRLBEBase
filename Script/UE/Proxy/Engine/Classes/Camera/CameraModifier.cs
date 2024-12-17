using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CameraModifier")]
	public partial class UCameraModifier : UObject, IStaticClass
	{
		public bool bDebug
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDebug, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDebug, __InBuffer);
				}
			}
		}

		public bool bExclusive
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bExclusive, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bExclusive, __InBuffer);
				}
			}
		}

		public byte Priority
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Priority, __ReturnBuffer);

					return *(byte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Priority, __InBuffer);
				}
			}
		}

		public APlayerCameraManager CameraOwner
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CameraOwner, __ReturnBuffer);

					return *(APlayerCameraManager*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CameraOwner, __InBuffer);
				}
			}
		}

		public float AlphaInTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AlphaInTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AlphaInTime, __InBuffer);
				}
			}
		}

		public float AlphaOutTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AlphaOutTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AlphaOutTime, __InBuffer);
				}
			}
		}

		public float Alpha
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Alpha, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Alpha, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.CameraModifier");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void OnCameraOwnerDestroyed(AActor InOwner)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InOwner?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnCameraOwnerDestroyed, __InBuffer);
			}
		}

		/// <returns>
		/// Returns true if modifier is disabled, false otherwise. */
		/// </returns>
		public virtual bool IsDisabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsDisabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Returns the actor the camera is currently viewing. */
		/// </returns>
		public virtual AActor GetViewTarget()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetViewTarget, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		public virtual void EnableModifier()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __EnableModifier);
			}
		}

		/// <param name="bImmediate">
		/// - true to disable with no blend out, false (default) to allow blend out
		/// </param>
		public virtual void DisableModifier(bool bImmediate = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bImmediate;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DisableModifier, __InBuffer);
			}
		}

		/// <param name="DeltaTime">
		/// Change in time since last update
		/// </param>
		/// <param name="PostProcessBlendWeight">
		/// (out) Blend weight applied to the entire postprocess structure.
		/// </param>
		/// <param name="PostProcessSettings">
		/// (out) Post process structure defining what settings and values to override.
		/// </param>
		public virtual void BlueprintModifyPostProcess(float DeltaTime, ref float PostProcessBlendWeight, ref FPostProcessSettings PostProcessSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(float*)(__InBuffer) = DeltaTime;

				*(float*)(__InBuffer + 4) = PostProcessBlendWeight;

				*(nint*)(__InBuffer + 8) = PostProcessSettings?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[12];

				FFunctionImplementation.FFunction_GenericCall6Implementation(GarbageCollectionHandle, __BlueprintModifyPostProcess, __InBuffer, __OutBuffer);

				PostProcessBlendWeight = *(float*)(__OutBuffer);

				PostProcessSettings = *(FPostProcessSettings*)(__OutBuffer + 4);

			}
		}

		/// <param name="DeltaTime">
		/// Change in time since last update
		/// </param>
		/// <param name="ViewLocation">
		/// The current camera location.
		/// </param>
		/// <param name="ViewRotation">
		/// The current camera rotation.
		/// </param>
		/// <param name="FOV">
		/// The current camera fov.
		/// </param>
		/// <param name="NewViewLocation">
		/// (out) The modified camera location.
		/// </param>
		/// <param name="NewViewRotation">
		/// (out) The modified camera rotation.
		/// </param>
		/// <param name="NewFOV">
		/// (out) The modified camera FOV.
		/// </param>
		public virtual void BlueprintModifyCamera(float DeltaTime, FVector ViewLocation, FRotator ViewRotation, float FOV, ref FVector NewViewLocation, ref FRotator NewViewRotation, ref float NewFOV)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[44];

				*(float*)(__InBuffer) = DeltaTime;

				*(nint*)(__InBuffer + 4) = ViewLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 12) = ViewRotation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 20) = FOV;

				*(nint*)(__InBuffer + 24) = NewViewLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = NewViewRotation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 40) = NewFOV;

				var __OutBuffer = stackalloc byte[20];

				FFunctionImplementation.FFunction_GenericCall6Implementation(GarbageCollectionHandle, __BlueprintModifyCamera, __InBuffer, __OutBuffer);

				NewViewLocation = *(FVector*)(__OutBuffer);

				NewViewRotation = *(FRotator*)(__OutBuffer + 8);

				NewFOV = *(float*)(__OutBuffer + 16);

			}
		}

		private static uint __bDebug = 0;

		private static uint __bExclusive = 0;

		private static uint __Priority = 0;

		private static uint __CameraOwner = 0;

		private static uint __AlphaInTime = 0;

		private static uint __AlphaOutTime = 0;

		private static uint __Alpha = 0;

		private static uint __OnCameraOwnerDestroyed = 0;

		private static uint __IsDisabled = 0;

		private static uint __GetViewTarget = 0;

		private static uint __EnableModifier = 0;

		private static uint __DisableModifier = 0;

		private static uint __BlueprintModifyPostProcess = 0;

		private static uint __BlueprintModifyCamera = 0;
	}
}